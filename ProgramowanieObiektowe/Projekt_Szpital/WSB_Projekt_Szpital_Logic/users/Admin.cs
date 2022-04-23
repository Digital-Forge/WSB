using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WSB_Projekt_Szpital_Logic
{
    [Serializable]
    public class Admin : User
    {
        public Admin() : base("", "", "", "", "", UserRoles.Admin)
        {
        }

        public Admin(string username, string password, string name, string surname, string pesel) : base(username, password, name, surname, pesel, UserRoles.Admin)
        {
        }
    }
}
