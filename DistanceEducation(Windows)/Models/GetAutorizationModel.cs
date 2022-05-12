using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DistanceEducation_Windows_.Models
{
    public class GetAutorizationModel
    {
        public int Id { get; set; }
        public int Role { get; set; }
       
        public GetAutorizationModel(int id, int role)
        {
            Id = id;
            Role = role;
        }
    }
}
