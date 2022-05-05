using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DistanceEducation_Windows_.Models
{
    internal class LessonDataItemModel
    {
        public Image ImageSubject { get; set; }
        public string NameSubject { get; set; }
        public string NameTeacher { get; set; }

        public LessonDataItemModel(Image imageSubject, string nameSubject, string nameTeacher)
        {
            ImageSubject = imageSubject;
            NameSubject = nameSubject;
            NameTeacher = nameTeacher;
        }

    }
}
