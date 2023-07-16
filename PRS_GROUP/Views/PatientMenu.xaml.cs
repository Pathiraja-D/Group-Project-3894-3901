using PRS_GROUP.ViewModels;
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
using System.Windows.Shapes;

namespace PRS_GROUP.Views
{
    /// <summary>
    /// Interaction logic for PatientMenu.xaml
    /// </summary>
    public partial class PatientMenu : Window
    {
        public PatientMenu(PatientMenuVM pmvm)
        {
            
            InitializeComponent();
            DataContext=pmvm;
            pmvm.CloseActionpatient = () => Close();
        }

        public PatientMenu()
        {
            InitializeComponent();
        }

        private void Window_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (e.LeftButton == MouseButtonState.Pressed)
                DragMove();
        }
        
        private void close_Click_1(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

       

        
    }
}
