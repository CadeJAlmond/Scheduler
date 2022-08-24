using System.Text;
using System.Text.RegularExpressions;

namespace Scheduler
{
    // Author : Cade Almond
    // Date   : 8/3/2022
    //
    // Class Contents 
    // This class will manage the creation, and presentation of
    // events into the program for users to implement. This form 
    // will allow the user to
    // 	1. Create Events
    // 	2. Mark Events as completed
    // 	3. Filter which Events are being displayed.
    // This class communicates with SQLHandle to read, create 
    //  and update events.  
    public partial class EventList : Form
    {
        public EventList()
        {
            InitializeComponent();
        }

        /// <summary>
        /// When the form begins, this method will load the uncompleted events
        /// from the SQL DB.
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
                _Event DisplayEvent = ToDisplay.Pop();
                EventDisplay EventUI = new EventDisplay();
                EventUI.Display(DisplayEvent);
                UpcomingEventsTable.Controls.Add(EventUI);
            }
        }

        /// <summary>
        /// This method is responsible for reading and evaluating the
        /// data inside of text fields related to adding information 
        /// into SQL. If the providing data is legal, than we insert
        /// the data into the SQL EventContainer.
        /// </summary>
        private void AddEventBtn_Click(object sender, EventArgs e)
        {
            // Checks the Data entered from the Date field
            if (!ValidDateFormat(out int _Case))
            {
                if (_Case == 1)
                {
                    MessageBox.Show("Please fill relevant data fields");
                    return;
                }
                if (_Case == 2)
                {
                    MessageBox.Show("Invalid Date entered. Please try again.");
                    return;
                }
                if (_Case == 3)
                {
                    MessageBox.Show("Please enter Date using yy-mm-dd format");
                    return;
                }
            }
            if (SQLHandle.AlreadyHasEvent("hi") == true) 
            {
                MessageBox.Show("This Event has already been added to SQL. Please try again.");
                return;
            }
            // If no priority level is estalibshed, set prio as 0 otherwise dont change it
            string ePrio = PriorityLvlTxtBox.Text == " " ? 
                ePrio = "0" : ePrio = PriorityLvlTxtBox.Text;

            // Insert Data into SQL 
            SQLHandle.InsertEvent(EventNameTxtBox.Text, EventDescTxtBox.Text,
                                  CompletionDateTxtBx.Text, ePrio );
            // Clear input fields
            PriorityLvlTxtBox.Text = EventNameTxtBox.Text = 
                EventDescTxtBox.Text = CompletionDateTxtBx.Text = " ";

            // Update UI
            UpcomingEventsTable.Controls.Clear();
            DisplaySQlInfo();
        }

        private string RemoveEmptyChars(string ToUpdate)
        {
            StringBuilder Updated = new StringBuilder();
            foreach(char Letter in ToUpdate)
                if(Letter != ' ')
                    Updated.Append(Letter);
            return Updated.ToString();

        }

        /// <summary>
        /// Checks the formating of the Date that was inputted into the 
        /// CompletionDate Text Box and will return if the format is 
        /// acceptable for SQL Use. 
        /// </summary>
        /// <param name="Case"></param>
        /// <returns></returns>
        private bool ValidDateFormat(out int Case) 
        {
            Case = 0;
            // Regex checks for yy/mm/dd format
            Regex DateFormat = new Regex(@"^\d{4}/\d{1,2}/\d{1,2}$");
            string Date      = RemoveEmptyChars ( CompletionDateTxtBx.Text );

            if (EventNameTxtBox.Text == "")
            {
                Case = 1;
                return false;
            }
            if (DateFormat.IsMatch(Date))
            {
                Case = 3;
                string[] DateInfo = Date.Split('/');
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

        // EVENTLIST Multi-Threading
    }
}
