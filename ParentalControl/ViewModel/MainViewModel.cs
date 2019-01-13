using System;
using System.Collections.Generic;
using System.Windows;

namespace ParentalControl
{
    public class MainViewModel : BaseViewModel
    {
        public string Login { set; get; } //Template cache fields used for data binding
        public string Password { set; get; }
        public bool ElevatedPrivileges { set; get;}
        public bool AccessGranted { set; get; }
        public List<User> UsersList { set; get; }

        public MainViewModel() //default constructor for the viewmodel, initiates the standard list of users
        {
            UsersList = new List<User>()
            {
                {new Administrator("admin","admin") },
                {new User("user", "123")},
            };
        }

        
        public bool CheckLoginStatus()
        {

            foreach (User user in UsersList)
            {
                if (Login == user.Login && Password == user.Password)
                {
                    return AccessGranted = user.ElevatedPrivileges;
                }
            }
            return AccessGranted;
            
        }
    }
}
