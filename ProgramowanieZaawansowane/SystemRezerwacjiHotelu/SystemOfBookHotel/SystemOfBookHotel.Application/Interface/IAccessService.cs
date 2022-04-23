using System;
using System.Collections.Generic;
using System.Text;
using SystemOfBookHotel.Application.ViewModel;

namespace SystemOfBookHotel.Application.Interface
{
    public interface IAccessService
    {
        bool CheckAccess(AccessVM data);
        bool Registration(AccessVM data);
    }
}
