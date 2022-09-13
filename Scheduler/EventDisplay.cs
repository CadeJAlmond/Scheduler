namespace Scheduler
{
    // Class Contents
    // This class represents a pre-existing event, which will
    // be displayed to the user so that they may choose to mark
    // an event as completed within the program. In this way, the
    // user may classify different events in multiple ways for
    // organizational purposes.

    public partial class EventDisplay : UserControl
    {
        public EventDisplay()
        {
            InitializeComponent();
        }

        // ###-------------------        UI Display        -------------------###

        /// <summary>
        /// Display the information of the given event, and place 
        /// its contents, the Event date into the radio button text
        /// and the Event name into a nearby text box to complete a 
        /// full Event to be displayed in the UI.
        /// </summary>
        /// <param name="ToDisplay"></param>
        public void Display(_Event ToDisplay) 
        {
            EventDateBtnLbl.Text  = ToDisplay.Date;
            EventTitle.Text       = ToDisplay.Name; 
        }

        public void DisplayCompletedEvent(_Event ToDisplay) 
        {
            EventDateBtnLbl.Text      = ToDisplay.Date;
            EventDateBtnLbl.ForeColor = Color.White;
            EventTitle.Text      = ToDisplay.Name;
        }

        /// <summary>
        /// Mark the Event being displayed in the UpcomingEvents window as 
        /// completed if the user clicks the button, next to the Event, 
        /// marking it as Completed in SQL, and in the UI. 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void EventDateBtnLbl_CheckedChanged(object sender, EventArgs e)
        {
            if (EventDateBtnLbl.Checked) 
            {
                // Gather Event Info
                string eName = EventTitle.Text.ToString();
                string eDate = EventDateBtnLbl.Text.ToString();
                // Update SQL
                SQLHandle.UpdateEvent(eName, eDate);
                // Change UI
                EventTitle.ForeColor = Color.CornflowerBlue;
                System.Drawing.Font MarkCompletedEvent = new System.
                    Drawing.Font("Segoe UI", 9, FontStyle.Strikeout);
                EventTitle.Font = MarkCompletedEvent;
            }
        }
    }
}
