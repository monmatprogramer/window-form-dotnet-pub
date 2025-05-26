using window_form_dotnet.Model;

namespace window_form_dotnet.Model.dao
    {
    public interface IAuthenticationDao
        {
        AuthenticationResult ValidateCredentials(string username, string password);
        bool ChangePassword(int userId, string oldPassword, string newPassword);
        bool ResetPassword(string username, string newPassword);
        bool LockUser(int userId);
        bool UnlockUser(int userId);
        bool IsUserLocked(int userId);
        }
    }