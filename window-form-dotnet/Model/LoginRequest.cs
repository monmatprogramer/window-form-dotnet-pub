namespace window_form_dotnet.Model
    {
    public class LoginRequest
        {
        public string Username { get; set; }
        public string Password { get; set; }
        public bool RememberMe { get; set; }

        public LoginRequest()
            {
            RememberMe = false;
            }

        public LoginRequest(string username, string password, bool rememberMe = false)
            {
            Username = username;
            Password = password;
            RememberMe = rememberMe;
            }
        }
    }
