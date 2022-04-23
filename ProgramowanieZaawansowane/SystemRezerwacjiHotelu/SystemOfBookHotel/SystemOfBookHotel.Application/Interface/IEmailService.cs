using System;
using System.Collections.Generic;
using System.Text;

namespace SystemOfBookHotel.Application.Interface
{
    public interface IEmailService
    {
        void SendMail(string to, string title, string text);
    }
}
