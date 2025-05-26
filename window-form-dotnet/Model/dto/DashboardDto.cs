using System;
using System.Collections.Generic;

namespace window_form_dotnet.Model.dto
    {
    public class DashboardDto
        {
        public UserDto CurrentUser { get; set; }
        public DateTime LoginTime { get; set; }
        public TimeSpan SessionDuration { get; set; }
        public List<string> RecentActivities { get; set; }
        public Dictionary<string, object> Statistics { get; set; }

        public DashboardDto()
            {
            RecentActivities = new List<string>();
            Statistics = new Dictionary<string, object>();
            }

        public DashboardDto(UserDto user, DateTime loginTime)
            {
            CurrentUser = user;
            LoginTime = loginTime;
            SessionDuration = DateTime.Now - loginTime;
            RecentActivities = new List<string>();
            Statistics = new Dictionary<string, object>();

            // Add default activities
            RecentActivities.Add($"Logged in at {loginTime:hh:mm tt}");
            RecentActivities.Add("Dashboard accessed");
            }

        // Display properties
        public string WelcomeMessage => $"Welcome back, {CurrentUser?.DisplayName ?? "User"}!";
        public string SessionTimeDisplay => $"{SessionDuration.Hours:D2}:{SessionDuration.Minutes:D2}:{SessionDuration.Seconds:D2}";
        public string LoginTimeDisplay => LoginTime.ToString("MMM dd, yyyy hh:mm tt");
        }
    }