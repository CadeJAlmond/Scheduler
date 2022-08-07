using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Scheduler
{
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
