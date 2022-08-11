using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Scheduler
{
    public partial class CalendarDay : UserControl
    {
        int Month, Year;
        public CalendarDay()
        {
            InitializeComponent();
            EventColorPanel1.Visible = false;
            EventColorPanel2.Visible = false;
        }

        public void AddDayLabel(string DisplayDay, int _Month, int _Year) 
        { 
            DayLabel.Text = DisplayDay;
          //  CheckForEvents($"{_Year}-{_Month}-{DisplayDay}");
        }

        private void CheckForEvents(string DateSearch) 
        {
            string Day = DayLabel.Text;
            bool search = SQLHandle.HasEvent(DateSearch);
            if(search)
                DisplayEvents(DateSearch);
            return;
        }

        public void DisplayEvents(string DateSearch) 
        {
            string Day = DayLabel.Text;
            Stack<_Event> EventList = SQLHandle.GetEvents(DateSearch);
            _Event EventAdd = EventList.Pop();
            EventColorPanel1.Visible = true;
            EventLabel1.Text = EventAdd.Name;
        }
    }
}
