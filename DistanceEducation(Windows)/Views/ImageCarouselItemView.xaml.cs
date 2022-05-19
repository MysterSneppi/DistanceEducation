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

namespace DistanceEducation_Windows_.Views
{
    /// <summary>
    /// Interaction logic for ImageCarouselItemView.xaml
    /// </summary>
    public partial class ImageCarouselItemView : UserControl
    {
        public object ImageSource
        {
            get { return (object)GetValue(ImageSourceProperty); }
            set { SetValue(ImageSourceProperty, value); }
        }
        public static readonly DependencyProperty ImageSourceProperty =
            DependencyProperty.Register("ImageSource", typeof(object), typeof(ImageCarouselItemView), new PropertyMetadata(0));

        public object Title
        {
            get { return (object)GetValue(TitleProperty); }
            set { SetValue(TitleProperty, value); }
        }
        public static readonly DependencyProperty TitleProperty =
            DependencyProperty.Register("Title", typeof(object), typeof(ImageCarouselItemView), new PropertyMetadata(0));

        public object Text
        {
            get { return (object)GetValue(TextProperty); }
            set { SetValue(TextProperty, value); }
        }

        // Using a DependencyProperty as the backing store for Text.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty TextProperty =
            DependencyProperty.Register("Text", typeof(object), typeof(ImageCarouselItemView), new PropertyMetadata(0));

        public object ImageWidth
        {
            get { return (object)GetValue(ImageWidthProperty); }
            set { SetValue(ImageWidthProperty, value); }
        }

        // Using a DependencyProperty as the backing store for ImageWidth.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty ImageWidthProperty =
            DependencyProperty.Register("ImageWidth", typeof(object), typeof(ImageCarouselItemView), new PropertyMetadata(0));
        public object ImageHeight
        {
            get { return (object)GetValue(ImageHeightProperty); }
            set { SetValue(ImageHeightProperty, value); }
        }

        // Using a DependencyProperty as the backing store for ImageHeight.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty ImageHeightProperty =
            DependencyProperty.Register("ImageHeight", typeof(object), typeof(ImageCarouselItemView), new PropertyMetadata(0));




        public object ButtonText
        {
            get { return (object)GetValue(ButtonTextProperty); }
            set { SetValue(ButtonTextProperty, value); }
        }

        // Using a DependencyProperty as the backing store for ButtonText.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty ButtonTextProperty =
            DependencyProperty.Register("ButtonText", typeof(object), typeof(ImageCarouselItemView), new PropertyMetadata(0));





        public ImageCarouselItemView()
        {
            InitializeComponent();
            this.DataContext = this;
        }
    }
}
