using System.ComponentModel.DataAnnotations;

namespace TwitterClone.Models
{
    public class User
    {
        [Key]
        public string Id { get; set; }
        [Required]
        public string Name { get; set; }
        public string Picture { get; set; }
        public string [] Followers { get; set; }
        public string [] Following { get; set; }
        [Required]
        public string Email { get; set; }
        [Required]
        public string Password { get; set; }
        public User() { }
        
    }
}
