
namespace DistanceEducation_Windows_.Providers
{
    public class SendAuthorizationData
    {
        /// <summary>
        /// Sends data to the server and receives a response in the form of Role and ID
        /// </summary>
        /// <param name="data"></param>
        public static async Task<GetAutorizationModel> SendData(AuthorizationModel data) {
          
            string Link = "http://testingapp.ddns.net:57000/get_user";
            string userName = System.Security.Principal.WindowsIdentity.GetCurrent().Name;

            GetAutorizationModel model;

            using (var client = new RestClient(Link))
            {

                var request = new RestRequest();                             
                var json = JsonSerializer.Serialize(data);
                request.AddBody(json);
                RestResponse<GetAutorizationModel> restResponse = await client.ExecutePostAsync<GetAutorizationModel>(request);
               // var response = client.PostAsync<GetAutorizationModel>(request);

                
                if (restResponse.StatusCode == System.Net.HttpStatusCode.NotFound) 
                {
                    throw new ArgumentException("No Connected to Server");
                }
                else 
                {                 
                    model = new GetAutorizationModel(restResponse.Data.Id, restResponse.Data.Role);

                    using (FileStream fstream = new FileStream($"C:\\Users\\aleks\\data.txt", FileMode.Create))
                    {
                        string datas = model.Role.ToString() + model.Id.ToString();
                        byte[] buffer = Encoding.Default.GetBytes(datas);
                        await fstream.WriteAsync(buffer, 0, buffer.Length);
                    }
                }
                
            }
            return model;
        }
    }
}
