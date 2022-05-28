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
    /// Interaction logic for GradesListItemView.xaml
    /// </summary>
    public partial class GradesListItemView : UserControl
    {

        public object Date
        {
            get { return (object)GetValue(DateProperty); }
            set { SetValue(DateProperty, value); }
        }

        // Using a DependencyProperty as the backing store for Date.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty DateProperty =
            DependencyProperty.Register("Date", typeof(object), typeof(GradesListItemView), new PropertyMetadata(0));




        public object GPA
        {
            get { return (object)GetValue(GPAProperty); }
            set { SetValue(GPAProperty, value); }
        }

        // Using a DependencyProperty as the backing store for GPA.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty GPAProperty =
            DependencyProperty.Register("GPA", typeof(object), typeof(GradesListItemView), new PropertyMetadata(0));



        public object NumberOfSubject
        {
            get { return (object)GetValue(NumberOfSubjectProperty); }
            set { SetValue(NumberOfSubjectProperty, value); }
        }

        // Using a DependencyProperty as the backing store for NumberOfSubject.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty NumberOfSubjectProperty =
            DependencyProperty.Register("NumberOfSubject", typeof(object), typeof(GradesListItemView), new PropertyMetadata(0));



        public object Class
        {
            get { return (object)GetValue(ClassProperty); }
            set { SetValue(ClassProperty, value); }
        }

        // Using a DependencyProperty as the backing store for Class.  This enables animation, styling, binding, etc...
        public static readonly DependencyProperty ClassProperty =
            DependencyProperty.Register("Class", typeof(object), typeof(GradesListItemView), new PropertyMetadata(0));





        public GradesListItemView()
        {
            InitializeComponent();
            this.DataContext = this;
        }
    }
}
