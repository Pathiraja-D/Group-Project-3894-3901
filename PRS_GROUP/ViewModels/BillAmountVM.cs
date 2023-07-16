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

namespace PRS_GROUP.ViewModels
{
    public partial class BillAmountVM:ObservableObject
    {
        //for billwindow
        public DataContext context = new DataContext();

        [ObservableProperty]
        public string customerid;
        [ObservableProperty]
        public string pfullname;
        [ObservableProperty]
        public double medfee;
        [ObservableProperty]
        public double hosfee;
        [ObservableProperty]
        public double docfee;
        [ObservableProperty]
        public double dis;
        [ObservableProperty]
        public double totfee;
        [ObservableProperty]
        public Patient patientobj;
        [ObservableProperty]
        public Patient? patientsave;

        public Action CloseActionbill { get; set; }
        public BillAmountVM(Patient patientpara)
        {
            patientobj = patientpara;
            customerid = patientobj.PNIC;
            pfullname = patientobj.PatientFirstName+" "+ patientobj.PatientLastName;
            medfee = patientobj.MedicineFee;
            hosfee = patientobj .HospitalFee;
            docfee = patientobj.HospitalFee;
            dis = patientobj.Discount;
            Totfee= patientobj.TotalFee;

        }
         
        public BillAmountVM()
        {

        }

        //create invoice
        [RelayCommand]
        public void Save()
        {
            patientsave = context.Patients.Find(customerid);
                if (medfee != 0 && hosfee != 0 && docfee != 0)
                {
                    patientsave.MedicineFee = medfee;
                    patientsave.HospitalFee = hosfee;
                    patientsave.DoctorFee = docfee;
                    patientsave.Discount = dis;
                    Totfee = patientsave.tamount();
                    context.Patients.Update(patientsave);
                    context.SaveChanges();
                    MessageBox.Show("Patient Invoice Saved");
                }
                else
                {
                    MessageBox.Show("Empty Field");
                }
            
        }


        [RelayCommand]

        public void backtopatientfrombill()
        {
            
            PatientMenuVM patbill = new PatientMenuVM(patientsave);
            PatientMenu patientinbill = new PatientMenu(patbill);
            this.CloseActionbill();
            patientinbill.Show();
            
        }

        

    }
}
