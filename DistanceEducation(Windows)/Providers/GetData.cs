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

        


    }
}
