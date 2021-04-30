using Balance_App.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Balance_App.ViewModels.Users
{
    public class IndexVM
    {
        public List<User> Items { get; set; }
        public Entities.Balance Balances { get; set; }
       

    }
}
