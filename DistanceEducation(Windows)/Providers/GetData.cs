namespace DistanceEducation_Windows_.Providers
{
    internal class GetData
    {       
        /// <summary>
        /// Get list Institutions
        /// </summary>
        /// <returns></returns>
        /// <exception cref="ArgumentException"></exception>
        public static async Task<List<InstitutionsModel>> GetListInstitution()
        {
            string Link = "http://testingapp.ddns.net:57000/get_institution";
            
            using (var client = new RestClient(Link))
            {
                var request = new RestRequest();
                var response = await client.ExecuteGetAsync<List<InstitutionsModel>>(request);             

                if (!response.IsSuccessful)
                {                 
                    throw new ArgumentException("No Connected \nList institutions not download \n : " + response.ErrorMessage + "\nStackTrace : " + response.ErrorException);
                }
                else
                {                   
                    List<InstitutionsModel> ListInstitutions = response.Data;
                    return ListInstitutions;
                }
            }
        }
        /// <summary>
        /// GetListHomeWorks
        /// </summary>
        public static async Task<List<HomeWorkModel>> GetHomeWork() 
        {
            string Link = "http://testingapp.ddns.net:57000/get_school_homework";
            int id;
            string path = $"C:\\Users\\aleks\\data.txt";
            using (StreamReader reader = new StreamReader(path)) 
            {
                string text = reader.ReadLine();
                id = Convert.ToInt32(text);              
            }


            using (RestClient client = new RestClient(Link)) 
            {
                RestRequest request = new RestRequest();
                var model = new { ID = id , Schema= "OFKKT" };
                var json = JsonSerializer.Serialize(model);
                request.AddJsonBody(json);
                RestResponse<List<HomeWorkModel>> restResponse = await client.ExecutePostAsync<List<HomeWorkModel>>(request);

                List<HomeWorkModel> list = restResponse.Data;
                return list;
            }
          

           
        }
    }
}
