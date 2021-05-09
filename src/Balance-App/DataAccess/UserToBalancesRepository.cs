using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Balance_App.Entities;

namespace Balance_App.DataAccess
{
        public class UserToBalanceRepository : BaseRepository<UserToBalance>
        {
            public UserToBalanceRepository()
            { }

            public UserToBalanceRepository(UnitOfWork uow)
                : base(uow)
            { }

            protected override IQueryable<UserToBalance> CascadeInclude(IQueryable<UserToBalance> query)
            {
                return query
                        .Include(utc => utc.ParentUser)
                        .Include(utc => utc.ParentBalance);
            }
        }


    
}
