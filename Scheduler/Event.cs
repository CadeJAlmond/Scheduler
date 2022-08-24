using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Scheduler
{
    // Author : Cade Almond
    // Date   : 8/3/2022
    //
    // Class Contents 
    // This class stimulates an event, defined as an activity, goal or event 
    // which the user hopes to be involved in, or accomplish by a specific 
    // date. These events are created in the EventList with the aid of the
    // SQLHandle, and ColorHandle, displayed in both the Calendar and
    // Eventlist app.  
    public class _Event
    {
        public string Name { get; set; }
        public string Desc { get; set; }
        public string Date { get; set; }
        public string Color { get; set; }
        public string Prio { get; set; }
        public _Event(string eName, string eColor, string eDesc, string eDueDate, string ePrio) 
        { 
            Name = eName;
            Color = eColor;
            Desc = eDesc;
            Date = eDueDate;
            Prio = ePrio; 
        }
    }
}
