using System;

namespace window_form_dotnet.Model.dto
    {
    public class UserDto
        {
        public int Id { get; set; }
        public string Username { get; set; }
        public string Email { get; set; }
        public string FullName { get; set; }
        public string Role { get; set; }
        public bool IsActive { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime? LastLoginDate { get; set; }

        public UserDto()
            {
            }

        public UserDto(User user)
            {
            if (user != null)
                {
                Id = user.Id;
                Username = user.Username;
                Email = user.Email;
                FullName = user.FullName;
                Role = user.Role;
                IsActive = user.IsActive;
                CreatedDate = user.CreatedDate;
                LastLoginDate = user.LastLoginDate;
                }
            }

        // Display properties for UI
        public string DisplayName => !string.IsNullOrEmpty(FullName) ? FullName : Username;
        public string RoleDisplay => Role ?? "User";
        public string StatusDisplay => IsActive ? "Active" : "Inactive";
        public string LastLoginDisplay => LastLoginDate?.ToString("MMM dd, yyyy hh:mm tt") ?? "Never";
        public string MemberSinceDisplay => CreatedDate.ToString("MMM dd, yyyy");
        }
    }
