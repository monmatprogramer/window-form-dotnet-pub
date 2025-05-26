using window_form_dotnet.Model.dto;

using window_form_dotnet.Model.dto;

namespace window_form_dotnet.Model
    {
    public class LoginResponse
        {
        public bool IsSuccess { get; set; }
        public string Message { get; set; }
        public UserDto User { get; set; }
        public string Token { get; set; }

        public LoginResponse()
            {
            IsSuccess = false;
            }

        public LoginResponse(bool isSuccess, string message)
            {
            IsSuccess = isSuccess;
            Message = message;
            }

        public LoginResponse(bool isSuccess, string message, UserDto user) : this(isSuccess, message)
            {
            User = user;
            }
        }
    }