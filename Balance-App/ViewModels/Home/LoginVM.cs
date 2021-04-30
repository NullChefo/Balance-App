using System.ComponentModel.DataAnnotations;
namespace Balance_App.ViewModels.Home
{
    public class LoginVM
    {
        [Required(ErrorMessage = "*This field is required!")]
        public string Username { get; set; }

        [Required(ErrorMessage = "*This field is required!")]
        public string Password { get; set; }

        public object FirstName { get; set; }

        public object LastName { get; set; }
    }
}
