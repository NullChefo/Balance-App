using Microsoft.EntityFrameworkCore;
using Balance_App.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace Balance_App.DataAccess
{
    public class BalanceRepository : BaseRepository<Balance>
    {
        public BalanceRepository()
        { }

        public BalanceRepository(UnitOfWork uow)
            : base(uow)
        { }

       protected override IQueryable<Balance> CascadeInclude(IQueryable<Balance> query)
        {
            return query.Include(c => c.ParentUser);
                       
        }
    }
}
