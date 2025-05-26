using System;

namespace window_form_dotnet.Model
    {
    public class User
        {
        public int Id { get; set; }
        public string Username { get; set; }
        public string PasswordHash { get; set; }
        public string Email { get; set; }
        public string FullName { get; set; }
        public string Role { get; set; }
        public bool IsActive { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime? LastLoginDate { get; set; }

        public User()
            {
            IsActive = true;
            CreatedDate = DateTime.Now;
            Role = "User";
            }

        public User(string username, string passwordHash, string email, string fullName) : this()
            {
            Username = username;
            PasswordHash = passwordHash;
            Email = email;
            FullName = fullName;
            }
        }
    }