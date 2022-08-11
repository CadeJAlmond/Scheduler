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

        /// <summary>
        /// When the form begins, it will load information from the SQL
        /// DB.
        /// </summary>
        private void EventList_Load(object sender, EventArgs e)
        {
            DisplaySQlInfo();
        }

        /// <summary>
        /// This method will query SQL for all uncompleted events to
        /// display for the user
        /// </summary>
        private void DisplaySQlInfo() 
        { 
            Stack<_Event> ToDisplay = SQLHandle.ListUncompletedEvents();  
            while(ToDisplay.Count > 0) 
            {
                _Event CurrentEvent = ToDisplay.Pop();
                EventDisplay EventUI = new EventDisplay();
                EventUI.Display(CurrentEvent);
                ThisWeekTable.Controls.Add(EventUI);
                // SortByTable.Controls.Add(EventUI);
            }
        }

        /// <summary>
        /// This method is responsible for reading and evaluating the
        /// date inside of fields related to adding information into SQL.
        /// </summary>
        private void AddEventBtn_Click(object sender, EventArgs e)
        {
            // Checks the Data entered from the Date field
            if (!ValidDateFormat(out int _Case))
            {
                if (_Case == 1)
                {
                    MessageBox.Show("Please fill Date field");
                    return;
                }
                if (_Case == 2)
                {
                    MessageBox.Show("Invalid Date entered");
                    return;
                }
                if (_Case == 3)
                {
                    MessageBox.Show("Please enter Date into yy-mm-dd format");
                    return;
                }
            }
            if (SQLHandle.ContainsEvent("hi") == true) 
            {
                MessageBox.Show("Event has already been added to SQL");
                return;
            }
            // If no priority level is estalibshed, set prio as 0 otherwise dont change it
            string ePrio = PriorityLvlTxtBox.Text == " " ? ePrio = "0" : ePrio = PriorityLvlTxtBox.Text;

            // Insert Data into SQL 
            SQLHandle.InsertEvent(EventNameTxtBox.Text, EventDescTxtBox.Text,
                                  CompletionDateTxtBx.Text, ePrio );
            // Clear input fields
            PriorityLvlTxtBox.Text = EventNameTxtBox.Text = 
                EventDescTxtBox.Text = CompletionDateTxtBx.Text = " ";

            ThisWeekTable.Controls.Clear();
            DisplaySQlInfo();
        }

        /// <summary>
        /// Checks the 
        /// </summary>
        /// <param name="Case"></param>
        /// <returns></returns>
        private bool ValidDateFormat(out int Case) 
        {
            Case = 0;
            // Regex checks for yy/mm/dd format
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

        /// <summary>
        /// This method will check if the given
        ///     1. Month > 12 
        ///     2. The given day is outside the bands of the given month.
        /// </summary>
        /// <returns></returns>
        private bool IsLegalDate(string Year, string Month, string Day) 
        {
            //Need to still check for days in month 
            if (int.Parse(Month) > 12)
                return false;
            else
                return true;
        }
    }
}
