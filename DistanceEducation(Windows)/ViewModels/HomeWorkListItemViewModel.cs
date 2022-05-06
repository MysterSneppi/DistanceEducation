namespace DistanceEducation_Windows_.ViewModels
{
    internal class HomeWorkListItemViewModel : ObservableObjects
    {
        public List<HomeWorkListItemView> items { get; set; }

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
            items = new List<HomeWorkListItemView>();
            for (int i = 0; i < 5; i++)
            {
                items.Add(new HomeWorkListItemView() { Date = "10.0.0", Exercise = "Номер 15", Subject = "Математика" });
                items.Add(new HomeWorkListItemView() { Date = "20.0.0", Exercise = "Параграф 12", Subject = "География" });
                items.Add(new HomeWorkListItemView() { Date = "30.0.0", Exercise = "Разрезать Максима ", Subject = "Биология" });
            }
            NumberOfTasks = items.Count();
        }
    }
}
