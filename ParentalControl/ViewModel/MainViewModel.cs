using System;
using System.Collections.Generic;
using System.Windows;

namespace ParentalControl
{
    public class MainViewModel : BaseViewModel
    {
        public string Login { set; get; } //Template cache fields used for data binding
        public string Password { set; get; }
        public bool AccessGranted { set; get; }
        public static string TimeLeft { set; get; } = "15";
        public List<User> UserList { set; get; }

        public MainViewModel() //default constructor for the viewmodel
        {
            UserList = new List<User>()            //initiates some default data
            {
                {new Administrator("admin","admin") },
                {new User("user", "123")},
            };
        }


        public bool CheckCredentials() //checks if user login and password match the data
        {

            foreach (User user in UserList)
            {
                if (Login == user.Login && Password == user.Password)
                {
                    AccessGranted = (user is Administrator) ? true : false;
                    return true;
                }
            }
            return false;
        }

        public static void UpdateTimer()
        {
            App.StaticTimer.TimeLeft = Convert.ToInt32(TimeLeft);
        }
    }
}
