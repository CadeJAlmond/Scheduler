using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Scheduler
{
    public partial class EventList : Form
    {
        public EventList()
        {
            InitializeComponent();
        }

        private void EventList_Load(object sender, EventArgs e)
        {
            GetSQlInfo();
        }

        private void GetSQlInfo() 
        { 
            Stack<_Event> ToDisplay = SQLHandle.ListUncompletedEvents();  
            while(ToDisplay.Count > 0) 
            {
                _Event CurrentEvent = ToDisplay.Pop();
                CalendarDay test = new CalendarDay();
                test.AddDayLabel(CurrentEvent.Name);
                ThisWeekTable.Controls.Add(test);
            }
        }

        private void AddEventBtn_Click(object sender, EventArgs e)
        {
            if (!ValidInputs(out int _Case))
            {
                if (_Case == 1)
                {
                    MessageBox.Show("1");
                    return;
                }
                if (_Case == 2)
                {
                    MessageBox.Show("2");
                    return;
                }
                if (_Case == 3)
                {
                    MessageBox.Show("3");
                    return;
                }
            }
            if (SQLHandle.ContainsEvent("hi") == true) 
            {
                MessageBox.Show("No");
                return;
            }
            string ePrio = PriorityLvlTxtBox.Text == " " ? ePrio = "0" : ePrio = PriorityLvlTxtBox.Text;

            SQLHandle.InsertEvent(EventNameTxtBox.Text, EventDescTxtBox.Text,
                                  CompletionDateTxtBx.Text, ePrio );

            PriorityLvlTxtBox.Text = EventNameTxtBox.Text = 
                EventDescTxtBox.Text = CompletionDateTxtBx.Text = " ";

            GetSQlInfo();
        }

        private bool ValidInputs(out int Case) 
        {
            Case = 0;
            Regex DateFormat = new Regex(@"^\d{4}/\d{1,2}/\d{1,2}$");
            if (EventNameTxtBox.Text == "")
            {
                Case = 1;
                return false;
            }
            if (DateFormat.IsMatch(CompletionDateTxtBx.Text))
            {
                Case = 3;
                string[] DateInfo = CompletionDateTxtBx.Text.Split('/');
                return IsLegalDate(DateInfo[0], DateInfo[1], DateInfo[2]);
            }
            Case = 2;
            return false;
        }

        private bool IsLegalDate(string Year, string Month, string Day) 
        {
            //Need to still check for 
            if (int.Parse(Month) > 12)
                return false;
            else
                return true;
        }
    }
}
