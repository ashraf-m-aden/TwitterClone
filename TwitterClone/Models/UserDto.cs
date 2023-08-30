namespace TwitterClone.Models
{
    public class UserDto  // user data transfert object   for login/register etc...
    {
        public string Email { get; set; } = string.Empty;
        public string Password { get; set; } = string.Empty;
    }
}
