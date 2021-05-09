using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage;
using Balance_App.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using System.Threading.Tasks;

namespace Balance_App.DataAccess
{
   
    public class UsersRepository : BaseRepository<User>
    {
        public UsersRepository()
        { }

        public UsersRepository(UnitOfWork uow)
            : base(uow)
        { }
    }
}
