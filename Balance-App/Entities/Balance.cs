using Balance_App.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Balance_App.Entities
{
    public class Balance : BaseEntity
    {

        [ForeignKey("UserId")]
        public int UserId { get; set; }
        public string NameOrType { get; set; }
        public string ExDate { get; set; }
        public decimal BalancesAmound { get; set; }
        public User ParentUser { get; set; }











    }


}
