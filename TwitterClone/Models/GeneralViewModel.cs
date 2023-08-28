namespace TwitterClone.Models
{
    public class GeneralViewModel
    {
        public UserDto userDto { get; set; } = new UserDto();
        public ConnectionState connectionState { get; set; } = new ConnectionState(false,true);
    }
}
