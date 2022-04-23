using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SystemOfBookHotel.Domain.Interface;
using SystemOfBookHotel.Domain.Model;

namespace SystemOfBookHotel.Infrastructure.Repositories
{
    public class ExtraPerkRepository : IExtraPerkRepository
    {
        private readonly Context _context;
        public ExtraPerkRepository(Context context)
        {
            _context = context;
        }

        public int AddExtraPerk(string name, bool active = false)
        {
            throw new NotImplementedException();
        }

        public IQueryable<ExtraPerk> GetListAllActivePerks()
        {
            return _context.ExtraPerks.Where(x => x.IsActive);
        }

        public IQueryable<ExtraPerk> GetListAllPerks()
        {
            return _context.ExtraPerks;
        }

        public void RemoveExtraPerkById(int id)
        {
            throw new NotImplementedException();
        }

        public void RemoveExtraPerkByItem(ExtraPerk item)
        {
            throw new NotImplementedException();
        }
    }
}
