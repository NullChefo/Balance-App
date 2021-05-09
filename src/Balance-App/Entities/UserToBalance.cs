using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;


namespace Balance_App.Entities
{
    public class UserToBalance : BaseEntity
    {
        public int UserId { get; set; }
        public int BalanceId { get; set; }

        [ForeignKey("UserId")]
        public User ParentUser { get; set; }
        [ForeignKey("BalanceId")]
        public Balance ParentBalance { get; set; }
    }
}
