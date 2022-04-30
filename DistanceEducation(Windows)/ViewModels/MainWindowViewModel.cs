namespace DistanceEducation_Windows_.ViewModels
{
    internal class MainWindowViewModel : ObservableObjects
    {

        #region Relays

        public RelayCommand MainPageCommand { get; set; }
        public RelayCommand HomeWorkPageCommand { get; set; }
        public RelayCommand LessonPageCommand { get; set; }
        public RelayCommand ChatsPageCommand { get; set; }
        public RelayCommand TestsPageCommand { get; set; }
        public RelayCommand GradesPageCommand { get; set; }
        public RelayCommand GradesListPageCommand { get; set; }
        public RelayCommand SettingsPageCommand { get; set; }
        #endregion
        #region Pages

        MainPage MainPage { get; set; }
        HomeWorksPage HomeWorkPage { get; set; }
        LessonPage LessonPage { get; set; }
        ChatsPage ChatsPage { get; set; }
        TestsPage TestsPage { get; set; }
        GradesPage GradesPage { get; set; }
        GradesListPage GradesListPage { get; set; }
        SettingsPage SettingsPage { get; set; }


        #endregion


        private object _currentView;

        public object CurrentView
        {
            get { return _currentView; }
            set
            {
                _currentView = value;
                OnPropertyChanged();
            }
        }

        public MainWindowViewModel()
        {
            MainPage = new MainPage();
            HomeWorkPage = new HomeWorksPage();
            LessonPage = new LessonPage();
            ChatsPage = new ChatsPage();
            TestsPage = new TestsPage();
            GradesPage = new GradesPage();
            GradesListPage = new GradesListPage();
            SettingsPage = new SettingsPage();


            CurrentView = MainPage;

            MainPageCommand = new RelayCommand(o =>
            {
                CurrentView = MainPage;
            });

            HomeWorkPageCommand = new RelayCommand(o =>
            {
                CurrentView = HomeWorkPage;
            });

            LessonPageCommand = new RelayCommand(o =>
            {
                CurrentView = LessonPage;
            });

            ChatsPageCommand = new RelayCommand(o =>
            {
                CurrentView = ChatsPage;
            });

            TestsPageCommand = new RelayCommand(o =>
            {
                CurrentView = TestsPage;
            });

            GradesPageCommand = new RelayCommand(o =>
            {
                CurrentView = GradesPage;
            });

            GradesListPageCommand = new RelayCommand(o =>
            {
                CurrentView = GradesListPage;
            });

            SettingsPageCommand = new RelayCommand(o =>
            {
                CurrentView = SettingsPage;
            });

        }

    }
}
