using System;
using System.Collections.Generic;
using System.Text;

namespace SystemOfBookHotel.Domain.Model
{
    public class ProgramSetting
    {
        // Defoult Value For Clients
        public string Currency { get; set; }
        public double PriceForRoom { get; set; }
        public double ChildConcession { get; set; }

        // Email Config
        public string HostSmtp { get; set; }
        public bool EnableSSL { get; set; }
        public int Port { get; set; }
        public string SenderEmail { get; set; }
        public string SenderEmailPassword { get; set; }
        public string SenderName { get; set; }
    }
}
