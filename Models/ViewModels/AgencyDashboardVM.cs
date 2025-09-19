using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TourismApp.Models.ViewModels
{
    public class AgencyDashboardVM
    {
        public string AgencyName { get; set; } = string.Empty;
        public string AgencyDescription { get; set; } = string.Empty;
        public int TotalTours { get; set; }
        public int ActiveBookings { get; set; }
        public decimal TotalRevenue { get; set; }
        public int PendingReviews { get; set; }
        public List<RecentBookingVM> RecentBookings { get; set; } = new List<RecentBookingVM>();
    }

    public class RecentBookingVM
    {
        public string PackageTitle { get; set; } = string.Empty;
        public DateTime BookingDate { get; set; }
        public int Participants { get; set; }
        public string Status { get; set; } = string.Empty;
        public decimal Revenue { get; set; }
    }
}