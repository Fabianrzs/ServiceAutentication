using System.ComponentModel.DataAnnotations;

namespace WebApiAutentication.Models
{
    public class User
    {
        [Key]
        public string UserName { get; set; }
        public string Email { get; set; }       
        public string Password { get; set; }
        public string Name { get; set; }
        public int State { get; set; }

    }
}
