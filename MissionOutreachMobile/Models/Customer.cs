using System;
using SQLite;
namespace MissionOutreachMobile.Models
{
    public class Customer
    {
        [PrimaryKey, AutoIncrement]
        public int ID { get; set; }
        public string QR { get; set; }
        public string Name { get; set; }
        public string ImageUrl { get; set; }
        public string Status { get; set; }
        public string DOB { get; set; }
    }
}
