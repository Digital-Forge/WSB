using System;
using System.Collections.Generic;
using System.Text;
using SystemOfBookHotel.Domain.ExtraModel;

namespace SystemOfBookHotel.Domain.Interface
{
    public interface IProgramSettingRepository
    {
        string GetCurrency();
        double GetPriceForRoom();
        double GetChildConcession();
        EmailConfig GetEmailConfig();
    }
}
