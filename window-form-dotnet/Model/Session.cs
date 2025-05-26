using System;

namespace window_form_dotnet.Model
    {
    public class Session
        {
        public int Id { get; set; }
        public int UserId { get; set; }
        public string SessionToken { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime ExpiryDate { get; set; }
        public bool IsActive { get; set; }
        public string IpAddress { get; set; }
        public string UserAgent { get; set; }

        public Session()
            {
            CreatedDate = DateTime.Now;
            ExpiryDate = DateTime.Now.AddHours(24); // Default 24 hours
            IsActive = true;
            SessionToken = Guid.NewGuid().ToString();
            }
        }
    }