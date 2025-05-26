namespace window_form_dotnet.Model.dto
    {
    public class LoginDto
        {
        public string Username { get; set; }
        public string Password { get; set; }
        public bool RememberMe { get; set; }

        public LoginDto()
            {
            RememberMe = false;
            }

        public LoginDto(string username, string password, bool rememberMe = false)
            {
            Username = username?.Trim();
            Password = password;
            RememberMe = rememberMe;
            }

        public bool IsValid()
            {
            return !string.IsNullOrWhiteSpace(Username) && !string.IsNullOrWhiteSpace(Password);
            }

        public LoginRequest ToLoginRequest()
            {
            return new LoginRequest(Username, Password, RememberMe);
            }
        }
    }