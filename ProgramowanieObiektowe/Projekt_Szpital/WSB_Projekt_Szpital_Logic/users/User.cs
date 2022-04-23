using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WSB_Projekt_Szpital_Logic
{
    [Serializable]
    public class User
    {
        public string Username { get; set; }
        public string Password { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Pesel { get; set; }

        public UserRoles Role { get; set; }

        public enum UserRoles
        {
            Admin,
            Doctor,
            Nurse
        }

        public User()
        {
        }

        public User(string username, string password, string name, string surname, string pesel, UserRoles role)
        {
            this.Username = username;
            this.Password = password;
            this.Name = name;
            this.Surname = surname;
            this.Pesel = pesel;
            this.Role = role;
        }

        public bool MinEquals(User other)
        {
            if (this.Username == other.Username)
            {
                return true;
            }
            return false;
        }
    }
}
