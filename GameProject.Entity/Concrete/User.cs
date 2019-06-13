using System.ComponentModel.DataAnnotations;
using Core.Entity;

namespace GameProject.Entity.Concrete
{
    public class User : IEntity
    {
        public int Id { get; set; }
        [Required]
        public string UserName { get; set; }
        [Required]
        public string Password { get; set; }
        [Compare("Password", ErrorMessage = "Password not same")]
        [Required]
        public string PasswordConfirm { get; set; }
        public string Role { get; set; } = "U";
    }
}
