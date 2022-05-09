using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DistanceEducation_Windows_.Models
{
    internal class AuthorizationModel
    {
        public string Login { get; set; }
        public string Password { get; set; }
        public string EducationInstitution { get; set; }

        public AuthorizationModel() { }
        public AuthorizationModel(string login, string password, string educationInstitution)
        {          
            Login = login;
            Password = password;
            EducationInstitution = educationInstitution;
        }

    }
}
