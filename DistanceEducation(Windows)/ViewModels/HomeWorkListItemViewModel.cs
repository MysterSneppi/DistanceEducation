namespace DistanceEducation_Windows_.ViewModels
{
    internal class HomeWorkListItemViewModel : BaseViewModel
    {
        public List<HomeWorkListItemView> items { get; set; }
        public List<HomeWorkModel> listHomeWork { get; set; }
        private int _numberOfTasks;

        public int NumberOfTasks
        {
            get { return _numberOfTasks; }
            set
            {
                _numberOfTasks = value;
                OnPropertyChanged();
            }
        }
        public HomeWorkListItemViewModel()
        {
            try
            {
                items = new List<HomeWorkListItemView>();
                GetListHomeWork();

                if (listHomeWork != null)
                {
                    foreach (var item in listHomeWork)
                    {
                        items.Add(new HomeWorkListItemView { Date = item.Date, Exercise = item.Exercise, Subject = item.Subject });
                    }

                    NumberOfTasks = items.Count();
                }
                else 
                {
                    MessageBox.Show("Не удалось получить список предметов");
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }           
        }

        private async void GetListHomeWork()
        {
            try
            {
                listHomeWork = await GetData.GetHomeWork();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
           
        }


    }
}
