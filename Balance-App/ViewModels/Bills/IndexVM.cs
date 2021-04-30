using Balance_App.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Balance_App.ViewModels.Bills
{
    public class IndexVM
    {
        public int ParentId { get; set; }
        public int BillAmound { get; set; }

        public Entities.Balance Balance { get; set; }
        public List<Bill> Items { get; set; }
        public decimal TotalBillsPerBalance { get; set; }
        public decimal BalanceAfterBills { get; set; }
    }
}
