using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MidtermConsole
{
    internal class User : IPasswordProtected
    {
        public string Name { get; }    
        public int Access {  get;  }        
        public string Password { get; private set; }

        public User(string name, int level, string password)
        { 
            if(level < 0 || level > 2) { throw new ArgumentOutOfRangeException("Invalid level."); }
            Name = name;
            Access = level;
            Password = password;
        }

        public bool checkPassword(string password)
        {
            if (Password.Equals(password))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool setPassword(string password)
        {
            if (password.Length < 5)
            {
                return false;
            }
            Password = password;
            return true;
        }

        public override string ToString()
        {
            return $"{Name} {Access}";
        }
    }
}
