using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Balance_App.Entities;

namespace Balance_App.ViewModels.Balance
{
    public class ShareVM
    {
        public List<int> UserIds { get; set; }
        public int BalanceId { get; set; }

        public Entities.Balance Balance { get; set; }
        public List<User> SharedWith { get; set; }

        public List<User> Users { get; set; }

    }
}
