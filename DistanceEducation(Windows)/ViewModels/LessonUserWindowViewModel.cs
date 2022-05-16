using System.Windows.Media.Imaging;
namespace DistanceEducation_Windows_.ViewModels
{
    internal class LessonUserWindowViewModel : BaseViewModel
    {

        private Image _image;
        public Image myImage3 { get { return _image; } set { _image = value; OnPropertyChanged(); } }


        public LessonUserWindowViewModel()
        {
            _image = new Image();
            BitmapImage bi3 = new BitmapImage();
            bi3.BeginInit();
            bi3.UriSource = new Uri("\\Resources\\Icons\\bell.png", UriKind.Relative);
            bi3.EndInit();
            myImage3.Source = bi3;

        }

    }
}
