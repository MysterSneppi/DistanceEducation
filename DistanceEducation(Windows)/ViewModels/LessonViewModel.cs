using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DistanceEducation_Windows_.ViewModels
{
    internal class LessonViewModel : BaseViewModel
    {
        public List<LessonUserWindowView> list { get; set; }

        

        public LessonViewModel() 
        {
            list = new List<LessonUserWindowView>();

            for (int i = 0; i < 10; i++) 
            {
                list.Add(new LessonUserWindowView());
            }
        }
       

    }
}
