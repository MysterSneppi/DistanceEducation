namespace DistanceEducation_Windows_.Providers
{
    internal class GetData
    {

        //webrtcgotest.ddns.net:57000
        //192.168.1.105:57000
        /// <summary>
        /// Get list Institutions
        /// </summary>
        /// <returns></returns>
        /// <exception cref="ArgumentException"></exception>
        public static async Task<List<InstitutionsModel>> GetListInstitution()
        {
            string Link = "http://webrtcgotest.ddns.net:57000/get_institution";
            
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
            string Link = "http://192.168.1.105:57000/get_school_homework";
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
                var model = new { ID = id, Schema= "OFKKT" };
                var json = JsonSerializer.Serialize(model);
                request.AddJsonBody(json);
                RestResponse<List<HomeWorkModel>> restResponse = await client.ExecutePostAsync<List<HomeWorkModel>>(request);

                List<HomeWorkModel> list = restResponse.Data;
              
                return list;
            }                  
        }

        public static async Task<List<GradesListModel>> GetGradesList() 
        {

            string Link = "http://192.168.1.105:57000/get_rates";
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
                var model = new { ID = id, Schema = "OFKKT" };
                var json = JsonSerializer.Serialize(model);
                request.AddJsonBody(json);
                var a = await client.ExecutePostAsync<object>(request);
                
                RestResponse<List<GradesListModel>> restResponse = await client.ExecutePostAsync<List<GradesListModel>>(request);            
                List <GradesListModel> list = restResponse.Data;              
                return list;
            }

        }

    }
}
