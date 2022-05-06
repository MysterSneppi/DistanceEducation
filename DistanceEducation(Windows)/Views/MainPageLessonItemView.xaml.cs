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
    /// Interaction logic for MainPageLessonItemView.xaml
    /// </summary>
    public partial class MainPageLessonItemView : UserControl
    {
        public static readonly DependencyProperty ImageProperty = DependencyProperty.Register("Image", typeof(object), typeof(MainPageLessonItemView), new PropertyMetadata(0));
        public object Image
        {
            get { return (object)GetValue(ImageProperty); }
            set { SetValue(ImageProperty, value); }
        }

        public static readonly DependencyProperty NameTeacherProperty = DependencyProperty.Register("NameTeacher", typeof(object), typeof(MainPageLessonItemView), new PropertyMetadata(0));
        public object NameTeacher
        {
            get { return (object)GetValue(NameTeacherProperty); }
            set { SetValue(NameTeacherProperty, value); }
        }

        public static readonly DependencyProperty SubjectProperty = DependencyProperty.Register("Subject", typeof(object), typeof(MainPageLessonItemView), new PropertyMetadata(0));
        public object Subject
        {
            get { return (object)GetValue(SubjectProperty); }
            set { SetValue(SubjectProperty, value); }
        }

        public MainPageLessonItemView()
        {
            InitializeComponent();
            this.DataContext = this;
        }
    }
}
