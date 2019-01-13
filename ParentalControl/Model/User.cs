using System.ComponentModel;


namespace ParentalControl
{
    public class User : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged = (sender, e) => { };
        public string Login { set; get; }
        public string Password { set; get; }
        public bool ElevatedPrivileges { protected set; get; }

        public User(string login, string password)
        {
            this.Login = login;
            this.Password = password;
            ElevatedPrivileges = false;
        }
        
    }
}

