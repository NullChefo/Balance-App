using System.ComponentModel.DataAnnotations;

namespace Balance_App.ViewModels.Balances
{
    public class CreateVM
    {
        [Required(ErrorMessage = "*This field is required")]
        public string NameOrType { get; set; }

        [Required(ErrorMessage = "*This field is required")]
        public string ExDate { get; set; }

        [Required(ErrorMessage = "*This field is required")]
        public decimal BalanceAmount { get; set; }
    }
}
