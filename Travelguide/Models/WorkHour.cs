using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Travelguide.Models
{
    public class WorkHour
    {
        public int Id { get; set; }
        public int PlaceId { get; set; }
        public int WeekNo { get; set; }
        //public TimeSpan, Nullable<Timespan> OpenHour { get; set; }
        //public TimeSpan, Nullable<Timespan> OpenHour { get; set; }

        public Place Place{ get; set; }
    }
}