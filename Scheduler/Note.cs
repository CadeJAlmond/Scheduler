using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Scheduler
{
    public class Note
    {
        public string Name { get; set; }
        public string Content { get; set; }
        public string Date { get; set; }

        public Note(string _Name, string _Content, string _Date) 
        {
            Name     = _Name;
            Content  = _Content;
            Date     = _Date;
        }
    }
}
