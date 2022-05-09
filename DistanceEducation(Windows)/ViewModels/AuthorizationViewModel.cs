using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DistanceEducation_Windows_.ViewModels
{
    internal class AuthorizationViewModel : ObservableObjects
    {
        //LVL user 
        //0-Admin 1-Teacher 2-Student
        private int _lvlUser;
        public int LvlUser 
        {
            get { return _lvlUser; }
            set { _lvlUser = value; OnPropertyChanged(); }
        }

        AuthorizationModel _authorizationModel { get; set; }
        ICommand StudentLVL;
        ICommand TeacherLVL;


        public AuthorizationViewModel() 
        {
            StudentLVL = new CommandBinding(Student);
            
        }

        private void Student() 
        {
            LvlUser = 2;
          
        }
        private void Teacher() 
        {
            LvlUser = 1;
        }

    }
}
