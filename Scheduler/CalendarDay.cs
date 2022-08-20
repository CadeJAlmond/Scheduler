namespace Scheduler
{
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
        }

        /// <summary>
        /// This method will query the SQL Database given a date, 
        /// and will display the event information occuring in that
        /// date onto the Calendar Display Day for users to see.
        /// This method will also draw the color associated with the
        /// events to the Calendar Display Day.
        /// </summary>
        public void DisplayEvents(string DateSearch) 
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

        private void UpdateFirstEvent(_Event EventToDisplay) 
        {
            EventColorPanel1.Visible   = true;
            EventColorPanel1.BackColor = DisplayColor;
            EventLabel1.Text = EventToDisplay.Name;
        }

        private void UpdateSecondEvent(_Event EventToDisplay1, _Event EventToDisplay2)
        {
            UpdateFirstEvent(EventToDisplay1);
            EventColorPanel2.Visible   = true;
            string EColor = EventToDisplay2.Color; 
            DisplayColor = System.Drawing.ColorTranslator
                .FromHtml($"{EColor.Substring(1, EColor.Length - 1)}");
            EventColorPanel2.BackColor = DisplayColor;
            EventLabel2     .Text      = EventToDisplay2.Name;
        }

        private void UpdateAllEvents(_Event EventToDisplay1, _Event EventToDisplay2, int RestOfEvents) 
        {
            UpdateSecondEvent(EventToDisplay1, EventToDisplay2);
            string UpdateEventLbl = EventLabel2.Text.ToString();
            UpdateEventLbl        = $"{UpdateEventLbl} +{RestOfEvents} More Events";
        }

    }
}
