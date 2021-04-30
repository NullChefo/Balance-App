using System.ComponentModel.DataAnnotations;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Balance_App.ViewModels.Bills
{
    public class EditVM
    {

        public int Id { get; set; }

        public int BalanceId { get; set; }

        [Required(ErrorMessage = "*This field is required")]
        public string BillName { get; set; }

        [Required(ErrorMessage = "*This field is required")]
        public decimal BillAmount { get; set; }



    }
}
