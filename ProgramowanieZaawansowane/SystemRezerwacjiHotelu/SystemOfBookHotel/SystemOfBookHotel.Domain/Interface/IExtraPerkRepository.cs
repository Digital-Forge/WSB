using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SystemOfBookHotel.Domain.Model;

namespace SystemOfBookHotel.Domain.Interface
{
    public interface IExtraPerkRepository
    {
        IQueryable<ExtraPerk> GetListAllPerks();
        IQueryable<ExtraPerk> GetListAllActivePerks();
        int AddExtraPerk(string name, bool active = false);
        void RemoveExtraPerkById(int id);
        void RemoveExtraPerkByItem(ExtraPerk item);
    }
}
