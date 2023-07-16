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
using System.Windows.Documents;
using System.Xml.Linq;

namespace PRS_GROUP.ViewModels
{
    public partial class UserMenuVM : ObservableObject
    {
        [ObservableProperty]
        public string? uNames;
        [ObservableProperty]
        public string? uPasswords;
        [ObservableProperty]
        public string? uconPasswords;
        [ObservableProperty]
        public string? uNICs;
        [ObservableProperty]
        public string? ucheckNICs;
        [ObservableProperty]
        public List<User>? databaseUsers;
        public Action Closeactionuser { get;set; }
        [ObservableProperty]
        public User? userfound = null;
        [ObservableProperty]
        public Admin useradmin;

        public DataContext context1 = new DataContext();


        

        public UserMenuVM(User userpara)
        {
            display();
        }

        public UserMenuVM() { }

        [RelayCommand]
        public void display()
        {
            DatabaseUsers=context1.Users.ToList();
        }
        

        

        [RelayCommand]
        

        public void usernull()
        {
            UNames = null;
            UPasswords = null;
            UconPasswords = null;
            UNICs = null;
            UcheckNICs = null;
        }

        [RelayCommand]
        public void create()
        {

            if (!string.IsNullOrEmpty(UNICs))
            {
                userfound = context1.Users.Find(UNICs);

                if (userfound == null)
                {
                    if(UPasswords==UconPasswords)
                    {
                        context1.Users.Add(new User() { UserName = UNames, Password = UPasswords, ConfirmPassword=UconPasswords, NIC = UNICs });
                        context1.SaveChanges();
                        MessageBox.Show("User Successfully Added");
                        display();
                        usernull();
                    }
                    
                }
                else
                {
                    MessageBox.Show("User already Exist");
                    usernull();
                }

            }

            else
            {
                MessageBox.Show("Empty User");

            }
        }

        [RelayCommand]
        public void Ufind()
        {

            userfound = context1.Users.Find(UcheckNICs);
            if (userfound != null)
            {
                UNICs = userfound.NIC;
                UNames = userfound.UserName;
                UPasswords = userfound.Password;
                UconPasswords = userfound.ConfirmPassword;

            }
            else
            {
                MessageBox.Show("No such User");
                usernull();
            }
        }


        [RelayCommand]
        public void delete()
        {
            userfound = context1.Users.Find(UcheckNICs);
            if (userfound != null)
            {
                context1.Remove(userfound);

                context1.SaveChanges();

                MessageBox.Show("User Successfully Deleted");
                usernull();

            }
            else
            {
                MessageBox.Show("Find a user to be deleted");
                usernull();
            }
        display();
        }

        [RelayCommand]

        public void uupdate()
        {
            userfound = context1.Users.Find(UNICs);
            if(userfound != null) 
            {
                if(UPasswords==UconPasswords)
                {
                    userfound.NIC = UNICs;
                    userfound.UserName = UNames;
                    userfound.Password = UPasswords;
                    userfound.ConfirmPassword = UconPasswords;
                    context1.Users.Update(userfound);
                    context1.SaveChanges();
                    MessageBox.Show("User details Successfully Updated");
                    display();
                    usernull();

                    
                }
                else
                {
                    MessageBox.Show("Check the passwords again.");
                    //usernull();
                }
            }
            else
            {
                MessageBox.Show("Find a registered user.");
                
            }
            
        }

        [RelayCommand]
        public void backtoadminfromuser()
        {
            AdminMenuVM aduser = new AdminMenuVM(useradmin);
            AdminMenu adminuser = new AdminMenu(aduser);
            this.Closeactionuser();
            adminuser.Show();
        }

    }
}
