using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace DistanceEducation_Windows_.Views.Buttons
{
    /// <summary>
    /// Interaction logic for LessonControlButtons.xaml
    /// </summary>
    public partial class LessonControlButton : UserControl
    {

        public static readonly DependencyProperty ImageProperty = DependencyProperty.Register("ImageSource", typeof(object), typeof(HomeWorkListItemView), new PropertyMetadata(0));
        public object ImageSource
        {
            get { return (object)GetValue(ImageProperty); }
            set { SetValue(ImageProperty, value); }
        }

        public static readonly DependencyProperty BackProperty = DependencyProperty.Register("BackColor", typeof(object), typeof(HomeWorkListItemView), new PropertyMetadata(0));
        public object BackColor
        {
            get { return (object)GetValue(BackProperty); }
            set { SetValue(BackProperty, value); }
        }

        public static readonly DependencyProperty WidthBorderProperty = DependencyProperty.Register("WidthBorder", typeof(object), typeof(HomeWorkListItemView), new PropertyMetadata(0));
        public object WidthBorder
        {
            get { return (object)GetValue(WidthBorderProperty); }
            set { SetValue(WidthBorderProperty, value); }
        }

        public static readonly DependencyProperty HeightBorderProperty = DependencyProperty.Register("HeightBorder", typeof(object), typeof(HomeWorkListItemView), new PropertyMetadata(0));
        public object HeightBorder
        {
            get { return (object)GetValue(HeightBorderProperty); }
            set { SetValue(HeightBorderProperty, value); }
        }

        public static readonly DependencyProperty CornerRadiusProperty = DependencyProperty.Register("CornerRadius", typeof(object), typeof(HomeWorkListItemView), new PropertyMetadata(0));
        public object CornerRadius
        {
            get { return (object)GetValue(CornerRadiusProperty); }
            set { SetValue(CornerRadiusProperty, value); }
        }
        public static readonly DependencyProperty ImageWidthProperty = DependencyProperty.Register("ImageWidtn", typeof(object), typeof(HomeWorkListItemView), new PropertyMetadata(0));
        public object ImageWidth
        {
            get { return (object)GetValue(ImageWidthProperty); }
            set { SetValue(ImageWidthProperty, value); }
        }
        public static readonly DependencyProperty ImageHeightProperty = DependencyProperty.Register("ImageHeight", typeof(object), typeof(HomeWorkListItemView), new PropertyMetadata(0));
        public object ImageHeight
        {
            get { return (object)GetValue(ImageHeightProperty); }
            set { SetValue(ImageHeightProperty, value); }
        }



        public LessonControlButton()
        {
            InitializeComponent();
            this.DataContext = this;
        }
    }
}
