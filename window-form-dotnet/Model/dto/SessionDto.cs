using System;

namespace window_form_dotnet.Model.dto
    {
    public class SessionDto
        {
        public int Id { get; set; }
        public int UserId { get; set; }
        public string SessionToken { get; set; } = string.Empty; // Fix for CS8618
        public DateTime CreatedDate { get; set; }
        public DateTime ExpiryDate { get; set; }
        public bool IsActive { get; set; }
        public string IpAddress { get; set; } = string.Empty; // Fix for CS8618
        public string UserAgent { get; set; } = string.Empty; // Fix for CS8618

        public SessionDto()
            {
            }

        public SessionDto(Session session)
            {
            if (session != null)
                {
                Id = session.Id;
                UserId = session.UserId;
                SessionToken = session.SessionToken ?? string.Empty; // Fix for CS8618
                CreatedDate = session.CreatedDate;
                ExpiryDate = session.ExpiryDate;
                IsActive = session.IsActive;
                IpAddress = session.IpAddress ?? string.Empty; // Fix for CS8618
                UserAgent = session.UserAgent ?? string.Empty; // Fix for CS8618
                }
            }

        // Helper properties
        public bool IsExpired => DateTime.Now > ExpiryDate;
        public TimeSpan TimeRemaining => ExpiryDate - DateTime.Now;
        public string StatusDisplay => IsActive && !IsExpired ? "Active" : "Inactive";
        public string DurationDisplay => $"{(DateTime.Now - CreatedDate).TotalMinutes:F0} minutes";
        }

    // Fix for CS0051: Make the Session class public
    public class Session
        {
        public int Id { get; set; }
        public int UserId { get; set; }
        public string SessionToken { get; set; } = string.Empty;
        public DateTime CreatedDate { get; set; }
        public DateTime ExpiryDate { get; set; }
        public bool IsActive { get; set; }
        public string IpAddress { get; set; } = string.Empty;
        public string UserAgent { get; set; } = string.Empty;
        }
    }