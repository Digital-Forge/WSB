using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WSB_Projekt_Szpital_Logic
{
    [Serializable]
    public class Doctor : User
    {
        public string NumberPWZ { get; set; }
        public string TypeDoctor { get; set; }

        public Doctor() : base("", "", "", "", "", UserRoles.Doctor)
        {
        }

        public Doctor(string username, string password, string name, string surname, string pesel, string nrPWZ, string typeDoctor) : base(username, password, name, surname, pesel, UserRoles.Doctor)
        {
            this.NumberPWZ = nrPWZ;
            this.TypeDoctor = typeDoctor;
        }
    }
}
