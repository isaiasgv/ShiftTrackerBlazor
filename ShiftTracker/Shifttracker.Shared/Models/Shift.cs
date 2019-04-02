using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ShiftTracker.Shared.Models
{
    public class Shift
    {

        public int Id { get; set; } = -1;
        public string Name { get; set; } = String.Empty;
        public string StartTime { get; set; } = DateTime.Now.ToString("yyyy-MM-ddTHH:mm:ss");
        public string EndTime { get; set; } = DateTime.Now.ToString("yyyy-MM-ddTHH:mm:ss");
        public string Description { get; set; } = String.Empty;
       // public String timeStamp = GetTimestamp(new DateTime());
        public string TotalHours { get; set; } = DateTime.Now.ToString("yyyy-MM-ddTHH:mm:ss");

       
    }
}
