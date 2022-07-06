using System;

namespace SavingInterface
{
    class PasswordManager : IDisplayable, IResetable // implements Q6 & Q11
    {
        // FIELDS // Q14 the Properties NEEDS a FIELD to back it!!
        private string _password;
        // PROPERTIES
        private string Password
        {
            get { return _password; }
            set
            {
                if (value.Length >= 8)
                    _password = value;
            }
        }

        public bool Hidden
        { get; private set; }

        public string HeaderSymbol
        { get; }

        // CONSTRUCTOR
        public PasswordManager(string password, bool hidden)
        {
            Password = password;
            Hidden = hidden;
        }

        public void Display() // Q7
        {
            if (Hidden)
            {
                Console.WriteLine(Password);
            }
            else
            {
                Console.WriteLine("********");
            }
        }

        public void Reset()
        {
            Password = "";
            Hidden = false;
        }

        public bool ChangePassword(string oldPass, string newPass)
        {
            if (oldPass == Password)
            {
                Password = newPass;
                return true;
            }
            else
                return false;
        }
    }
}