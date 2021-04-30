using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Balance_App.Entities
{
    public class Bill : BaseEntity
    {
        
        public int BalanceId { get; set; }
        public string Name { get; set; }
        public decimal BillAmount { get; set; }
        [ForeignKey("BalanceId")]
        public Balance ParentBalance { get; set; }




    }

    
}
