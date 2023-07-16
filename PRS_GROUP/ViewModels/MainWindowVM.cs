using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using PRS_GROUP.Models;
using PRS_GROUP.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media.Imaging;

namespace PRS_GROUP.ViewModels
{
    public partial class MainWindowVM:ObservableObject
    {
        [ObservableProperty]
        public string? userName;

        [ObservableProperty]
        public string? password;
        public Action CloseActionmain { get;set; }

        public Patient pinmain;

        public Admin ainmain;

        public MainWindowVM(Patient pparaformain) { }

        public MainWindowVM() { }

        


        [RelayCommand]
        public void Access()
        {
            using (DataContext context = new DataContext())
            {
                
                bool userfound = context.Users.Any(Users => Users.UserName == userName && Users.Password == Password);
                bool adminfound = context.Admins.Any(Admins => Admins.AdminName == userName && Admins.AdminPassword == Password);

                if (userfound)
                {
                    GrantAccessToPatient();
                }
                else if (adminfound)
                {   
                    
                    GrantAccessToAdmin();
                }
                else
                {
                    MessageBox.Show("Invalid Credentials.");
                }
                

            }
        }

        
        public void GrantAccessToAdmin()
        {
            AdminMenuVM admain=new AdminMenuVM(ainmain);
            AdminMenu admin = new AdminMenu(admain);
            admin.Show();
            Application.Current.MainWindow.Close();

        }

        
        public void GrantAccessToPatient()
        {
            PatientMenuVM patvm = new PatientMenuVM(pinmain);
            PatientMenu patient = new PatientMenu(patvm);
            patient.Show();
            Application.Current.MainWindow.Close();
        }

    }
}
