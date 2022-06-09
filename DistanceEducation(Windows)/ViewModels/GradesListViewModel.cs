using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DistanceEducation_Windows_.ViewModels
{
    internal class GradesListViewModel : BaseViewModel
    {
        public List<GradesListItemView> items { get; set; }
        public List<GradesListModel> gradesList { get; set; }

        private int _numberOfGrades;

        public int NumberOfGrades
        {
            get { return _numberOfGrades; }
            set
            {
                _numberOfGrades = value;
                OnPropertyChanged();
            }
        }

        public GradesListViewModel() 
        {
            try
            {
                items = new List<GradesListItemView>();
                GetGradesList();
                ReloadData();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
        private async void GetGradesList()
        {
            try
            {
                gradesList = await GetData.GetGradesList();
                ReloadData();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

        }

        private void ReloadData()
        {
            if (gradesList != null)
            {
                foreach (var item in gradesList)
                {
                    items.Add(new GradesListItemView{Date = item.Year , NumberOfSubject = item.NumberOfSubject, Class=item.Semester , GPA = item.AverageRateAll});
                }
                NumberOfGrades = items.Count();
            }
            else
            {
                 MessageBox.Show("Не удалось получить список табелей");
            }
        }

    }
}
