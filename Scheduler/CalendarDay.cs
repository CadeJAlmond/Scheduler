namespace Scheduler
{
    // Class Contents
    // This class represents a day in the Calendar form.
    // A day may posses an event which is too be displayed 
    // within the larger Calendar enviroment. This calendar
    // day will display the Day, and any events which
    // corresponde to that specific day in the month.
    public partial class CalendarDay : UserControl
    {
        System.Drawing.Color DisplayColor;
        public CalendarDay()
        {
            InitializeComponent();
            EventColorPanel1.Visible = false;
            EventColorPanel2.Visible = false;
        }

        /// <summary>
        /// This method will add the given date to the Calendar 
        /// Display Day for users to see.
        /// </summary>
        public void AddDayLabel(string DisplayDay) 
        { 
            DayLabel.Text = DisplayDay;
            ClearDisplay();
        }

        private void ClearDisplay() 
        {
            // Make the Calendar day invisible if this day is not apart of the
            // month that is being displayed
            if (DayLabel.Text == " ")
                BackColor = System.Drawing.ColorTranslator
            .FromHtml("Transparent");
            // Redraw the background if it was made invisible previously
            else
                BackColor = System.Drawing.Color.FromArgb(27, 27, 27);
            // Since AddDayLabel was called, no events are to be shown
            EventColorPanel1.Visible = false;
            EventColorPanel2.Visible = false;
            EventLabel1.Text = "";
            EventLabel2.Text = "";
        }

        /// <summary>
        /// This method will query the SQL Database given a date, 
        /// and will display the event information occuring in that
        /// date onto the Calendar Display Day for users to see.
        /// This method will also draw the color associated with the
        /// events to the Calendar Display Day.
        /// </summary>
        public void DisplayEvents(string DisplayDay, string DateSearch) 
        {
            // Gather Event Info
            Stack<_Event> EventList = SQLHandle.GetEvents(DateSearch);
            _Event EventAdd = EventList.Pop();
            string EColor   = EventAdd.Color.ToString();
                   DisplayColor  = System.Drawing.ColorTranslator
                .FromHtml($"{EColor.Substring(1, EColor.Length - 1)}");
            // Update UI
            switch (EventList.Count()) 
            {
                case 0:
                    UpdateFirstEvent(EventAdd);
                    break;
                case 1:
                    UpdateSecondEvent(EventAdd, EventList.Pop());
                    break;
                default:
                    UpdateAllEvents(EventAdd, EventList.Pop(), EventList.Count());
                    break;
            }
        }

        /// <summary>
        /// This method will display the Name, and Color of the
        /// given a singular Event to the CalendarDay which is 
        /// being displayed to the Calendar.
        /// </summary>
        /// <param name="EventToDisplay"></param>
        private void UpdateFirstEvent(_Event EventToDisplay) 
        {
            EventColorPanel1.Visible   = true;
            EventColorPanel1.BackColor = DisplayColor;
            EventLabel1.Text = EventToDisplay.Name;
        }

        /// <summary>
        /// This method will display the Names, and Colors of the
        /// given a pair of Events occuring in the CalendarDay which 
        /// is being displayed to the Calendar.
        /// </summary>
        private void UpdateSecondEvent(_Event EventToDisplay1, _Event EventToDisplay2)
        {
            // Display the first Event
            UpdateFirstEvent(EventToDisplay1);
            // Display the second Event
            EventColorPanel2.Visible   = true;
            string EColor = EventToDisplay2.Color; 
            DisplayColor  = System.Drawing.ColorTranslator
                .FromHtml($"{EColor.Substring(1, EColor.Length - 1)}");
            EventColorPanel2.BackColor = DisplayColor;
            EventLabel2     .Text      = EventToDisplay2.Name;
        }

        /// <summary>
        /// This method will display the Names, and Colors of the
        /// given two+ Events occuring in the CalendarDay which is 
        /// being displayed to the Calendar.
        /// </summary>
        private void UpdateAllEvents(_Event EventToDisplay1, _Event EventToDisplay2, int RestOfEvents) 
        {
            // Display the First and Second Events
            UpdateSecondEvent(EventToDisplay1, EventToDisplay2);
            // Update to include the Number of events not being displayed
            string UpdateEventLbl = EventLabel2.Text.ToString();
            EventLabel2.Text = $"{UpdateEventLbl} +{RestOfEvents} More Events";
        }

    }
}
