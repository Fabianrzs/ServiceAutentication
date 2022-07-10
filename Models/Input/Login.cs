using System.ComponentModel.DataAnnotations;

namespace WebApiAutentication.Models
{
    public class Login
    {
        [Key]
        [Required]
        public string UserName { get; set; }
        [Required]
        public string Password { get; set; }
    }
}
