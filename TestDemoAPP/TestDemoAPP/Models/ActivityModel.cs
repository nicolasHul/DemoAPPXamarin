using System;
using System.Collections.Generic;
using System.Text;

namespace TestDemoAPP.Models
{

    public class ActivityLocation
    {
        public int LocationId { get; set; }
        public string LocationName { get; set; }
        public List<ActivityFloor> CurrentFloors { get; set; } 
    }

    public class ActivityFloor
    {
        public int FloorId { get; set; } 
        public string FloorName { get; set; }
    }

}
