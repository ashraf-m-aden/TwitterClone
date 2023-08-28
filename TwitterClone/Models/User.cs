using System.ComponentModel.DataAnnotations;

namespace TwitterClone.Models
{
    public class User // this is the model of the user
    {
        [Key]
        public string Id { get; set; }
        [Required]
        public string Name { get; set; } = string.Empty;
        public string Picture { get; set; } = string.Empty;
        public string [] Followers { get; set; } = Array.Empty<string>();
        public string[] Following { get; set; } = Array.Empty<string>();
        [Required]
        public string Email { get; set; }
        [Required]
        public byte[] PasswordSalt { get; set; }
        public byte[] PasswordHash { get; set; }
        public User() { }
        
    }
}
