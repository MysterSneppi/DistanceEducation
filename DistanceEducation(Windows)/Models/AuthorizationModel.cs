using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DistanceEducation_Windows_.Models
{
    public class AuthorizationModel
    {
        public string Login { get; set; }
        public string Password { get; set; }
        public string EducationInstitution { get; set; }
        public AuthorizationModel() { }
        public AuthorizationModel(string Login, string Password, string EducationInstitution)
        {
            this.Login = Login;
            string pass = MD5Hash.Crypt(Password);
            this.Password = pass.ToLower();
            this.EducationInstitution = EducationInstitution;
        }
    }
}
