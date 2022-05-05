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
    /// Interaction logic for HomeWorkListItemView.xaml
    /// </summary>
    public partial class HomeWorkListItemView : UserControl
    {
        public static readonly DependencyProperty DateProperty = DependencyProperty.Register("Date", typeof(object), typeof(HomeWorkListItemView), new PropertyMetadata(0));
        public object Date
        {
            get { return (object)GetValue(DateProperty); }
            set { SetValue(DateProperty, value); }
        }

        public static readonly DependencyProperty ExerciseProperty = DependencyProperty.Register("Exercise", typeof(object), typeof(HomeWorkListItemView), new PropertyMetadata(0));
        public object Exercise 
        {
            get { return (object)GetValue(ExerciseProperty); }
            set { SetValue(ExerciseProperty, value); }
        }

        public static readonly DependencyProperty SubjectProperty = DependencyProperty.Register("Subject", typeof(object), typeof(HomeWorkListItemView), new PropertyMetadata(0));
        public object Subject
        {
            get { return (object)GetValue(SubjectProperty); }
            set { SetValue(SubjectProperty, value); }
        }

        


        
       
        
        
        
        public HomeWorkListItemView()
        {
            InitializeComponent();
            this.DataContext = this;
        }
    }
}
