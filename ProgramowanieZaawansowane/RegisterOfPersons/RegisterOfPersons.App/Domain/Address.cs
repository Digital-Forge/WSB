using RegisterOfPersons.ConsoleTerminal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegisterOfPersons.App
{
    [Serializable]
    public class Address : IConsoleReadable
    {
        public string City { get; set; }
        public string Street { get; set; }
        public string HouseNo { get; set; }
        public string FlatNo { get; set; }
        public string PostalCode { get; set; }
    }
}
