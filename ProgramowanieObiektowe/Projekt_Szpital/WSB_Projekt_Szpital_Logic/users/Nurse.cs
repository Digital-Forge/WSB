using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace WSB_Projekt_Szpital_Logic
{
    [Serializable]
    public class Nurse : User
    {
        [XmlArrayItem(typeof(StringModulNurseAbilitie))]
        public List<StringModulNurseAbilitie> Abilities { get; set; }

        public Nurse() : base("", "", "", "", "", UserRoles.Nurse)
        {
            this.Abilities = new List<StringModulNurseAbilitie>();
        }

        public Nurse(string username, string password, string name, string surname, string pesel) : base(username,password,name,surname,pesel,UserRoles.Nurse)
        {
            this.Abilities = new List<StringModulNurseAbilitie>();
        }

    }

    [Serializable]
    public class StringModulNurseAbilitie
    {
        public string Abilitie { get; set; }
    }
}
