using System.ComponentModel;

namespace ParentalControl
{
    class Administrator : User
    {
        public Administrator(string login, string password) : base(login, password)
        {
            this.Login = login;
            this.Password = password;
            ElevatedPrivileges = true;
        }
    }
}
