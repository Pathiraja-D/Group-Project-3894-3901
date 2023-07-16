using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using PRS_GROUP.Models;
using PRS_GROUP.Views;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace PRS_GROUP.ViewModels
{
    public partial class PatientMenuVM:ObservableObject
    {
        [ObservableProperty]
        public List<Patient>? databasePatients;

        [ObservableProperty]
        public Patient? patientfound=null;

        //for patient window
        public DataContext context=new DataContext();

        [ObservableProperty]
        public string pNICs;
        [ObservableProperty]
        public string pfindNICs;
        [ObservableProperty]
        public string? pFNames;
        [ObservableProperty]
        public string? pLNames;
        [ObservableProperty]
        public string? pAdd;
        [ObservableProperty]
        public string? pNo;
        [ObservableProperty]
        public string? pDate;

        [ObservableProperty]
        public Patient pattemp;
        public Action CloseActionpatient { get; set; }

        [RelayCommand]
        public void Pdisplay()
        {
            DatabasePatients = context.Patients.ToList();           
        }

        public PatientMenuVM(Patient patientpara)
        {
            Pdisplay();
        }

        public PatientMenuVM() { }

        public void nullfunc()
        {
            PNICs = null;
            PFNames=null;
            PLNames=null;
            PAdd = null;
            PNo = null;
            PDate = null;
            PfindNICs = null;
        }
        
        [RelayCommand]
        //create
        public void Pcreate()
        {
                if (!string.IsNullOrEmpty(PNICs))
                {
                    patientfound = context.Patients.Find(PNICs);
                    if (patientfound==null)
                    {
                        context.Patients.Add(new Patient() { PNIC = PNICs, PatientFirstName = PFNames, PatientLastName = PLNames, Address = PAdd, T_Number = PNo, Date = PDate });
                        context.SaveChanges();
                        MessageBox.Show("Successfully Added");
                        Pdisplay();
                        nullfunc();
                    }
                    else
                    {
                        MessageBox.Show("User Already Exist");
                        nullfunc();
                    }
                }

                else
                {
                    MessageBox.Show("Empty Field");
                }
        }


        [RelayCommand]
        public void PUpdate()
        {
            patientfound = context.Patients.Find(PfindNICs); //check here if the code doenst work
            if (patientfound != null || pNICs != null)
            {
                patientfound.PatientFirstName = pFNames;
                patientfound.PatientLastName = PLNames;
                patientfound.Address = pAdd;
                patientfound.T_Number = pNo;
                patientfound.Date = pDate;
                context.Patients.Update(patientfound);
                context.SaveChanges();
                MessageBox.Show("Patient details Successfully Updated");
                Pdisplay();
                patientfound = null;
                nullfunc();
            }
            else
            {
                MessageBox.Show("Select a field from the table");

            }
        }

        

        [RelayCommand]
        public void PDelete()
        {
            patientfound = context.Patients.Find(PfindNICs);
               if (patientfound !=null)
                {
                    context.Remove(patientfound);

                    context.SaveChanges();

                    MessageBox.Show("Successfully Deleted");
                    Pdisplay();
                    nullfunc();

                }
                else
                {
                    MessageBox.Show("Find a patient to be deleted ");
                }
        }

        [RelayCommand]
        public void Pfind()
        {
            var patobj = new Patient();
            patobj = context.Patients.Find(PfindNICs);
            if (patobj != null)
            {
                PNICs = patobj.PNIC;
                PFNames = patobj.PatientFirstName;
                PLNames = patobj.PatientLastName;
                PAdd = patobj.Address;
                PNo = patobj.T_Number;
                PDate = patobj.Date;

            }
            else
            {
                MessageBox.Show("No such Patient");
                nullfunc();
            }
        }



        
        [RelayCommand]
        public void back_to_mainfrompatient()
        { 
            MainWindow newmain  = new MainWindow();
            this.CloseActionpatient();
            newmain.Show();
        }




        //patient invoice
        [RelayCommand]
        public void Createbill()
        {
            patientfound = context.Patients.Find(PNICs);
            if(patientfound !=null)
            {
                nullfunc();
                var billvm = new BillAmountVM(patientfound);
                BillAmount BillWindow=new BillAmount(billvm);
                BillWindow.Show();
                this.CloseActionpatient();
                
            }
            else
            {
                MessageBox.Show("Find the Patient First","Error");
            }
            
        }



       



    }
}
