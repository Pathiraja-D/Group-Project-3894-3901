using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using PRS_GROUP.Models;
using PRS_GROUP.Views;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRS_GROUP.ViewModels
{
    public partial class AdminMenuVM:ObservableObject
    {
        
        public Action CloseActionadmin { get; set; }

        [ObservableProperty]
        public Patient patienttemp;
        [ObservableProperty]
        public User usertemp;

        public AdminMenuVM(Admin admintemp) { }
        public AdminMenuVM() { }

        [RelayCommand]
        public void GrantAccessToUserfromAdmin()
        {

            UserMenuVM uvm = new UserMenuVM(Usertemp);
            UserMenu user = new UserMenu(uvm);
            user.Show();
            this.CloseActionadmin();
        }

        [RelayCommand]
        public void GrantAccessToPatientfromAdmin()
        {
            PatientMenuVM patvm = new PatientMenuVM(Patienttemp);
            PatientMenu patient = new PatientMenu(patvm);
            patient.Show();
            this.CloseActionadmin();
        }


    }
}
