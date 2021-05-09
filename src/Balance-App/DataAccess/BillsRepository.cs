using Microsoft.EntityFrameworkCore;
using Balance_App.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Balance_App.DataAccess
{
    public class BillsRepository : BaseRepository<Bill>
    {
        public BillsRepository()
        { }

        public BillsRepository(UnitOfWork uow)
            : base(uow)
        { }

        protected override IQueryable<Bill> CascadeInclude(IQueryable<Bill> query)
        {
            return query
                    .Include(p => p.ParentBalance);
        }
    }
}
