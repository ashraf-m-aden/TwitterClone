namespace TwitterClone.Models
{
    public class ConnectionState
    {

        public ConnectionState(bool isLoggedIn, bool isSignIn)
        {
            IsLoggedIn = isLoggedIn;
            IsSignIn = isSignIn;
        }

        public bool IsLoggedIn { get; set; } = false;
        public bool IsSignIn { get; set; }  = true;
    }
}
