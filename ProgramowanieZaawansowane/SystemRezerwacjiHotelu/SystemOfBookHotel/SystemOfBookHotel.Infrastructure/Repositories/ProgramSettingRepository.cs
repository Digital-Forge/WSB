using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SystemOfBookHotel.Domain.ExtraModel;
using SystemOfBookHotel.Domain.Interface;

namespace SystemOfBookHotel.Infrastructure.Repositories
{
    public class ProgramSettingRepository : IProgramSettingRepository
    {
        private readonly Context _context;

        public ProgramSettingRepository(Context context)
        {
            _context = context;
        }

        public double GetChildConcession()
        {
            return _context.ProgramSettings.FirstOrDefault().ChildConcession;
        }

        public string GetCurrency()
        {
            return _context.ProgramSettings.FirstOrDefault().Currency;
        }
        
        public double GetPriceForRoom()
        {
            return _context.ProgramSettings.FirstOrDefault().PriceForRoom;
        }
        
        public EmailConfig GetEmailConfig()
        {
            var buff = _context.ProgramSettings.FirstOrDefault();

            return new EmailConfig
            {
                HostSmtp = buff.HostSmtp,
                EnableSSL = buff.EnableSSL,
                Port = buff.Port,
                SenderEmail = buff.SenderEmail,
                SenderEmailPassword = buff.SenderEmailPassword,
                SenderName = buff.SenderName
            };
        }

    }
}
