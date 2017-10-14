using System;
using System.Collections.Generic;

namespace MissionOutreachMobile.Models
{
    public class CustomerGroup : List<Customer>
    {
        public string Title { get; set; }
        public string ShortTitle { get; set; }

        public CustomerGroup(string title, string shortTitle)
        {
            Title = title;
            ShortTitle = shortTitle;
        }
    }
}
