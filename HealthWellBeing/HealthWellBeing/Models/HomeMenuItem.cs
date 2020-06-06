using System;
using System.Collections.Generic;
using System.Text;

namespace HealthWellBeing.Models
{
    public enum MenuItemType
    {
        Browse,
        About,
        HealthWellBeing,
        WellBeingTracker,
        DailyRoutine,
        AccountOverview,
        Logout
    }
    public class HomeMenuItem
    {
        public MenuItemType Id { get; set; }

        public string Title { get; set; }
    }
}

