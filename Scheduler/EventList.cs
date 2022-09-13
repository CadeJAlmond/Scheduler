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
    // This class communicates with SQLHandle to read and create
    // events.  
    public partial class EventList : Form
    {

        // ###-------------------        Page Setup        -------------------###

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

        // ###-------------------        UI Display        -------------------###

        /// <summary>
        /// This method will query SQL for all uncompleted events to
        /// display for the user
        /// </summary>
        private void DisplaySQlInfo() 
        {
            // Fill Upcoming Events Grid
            bool GetCompletedEvents;
            Stack<_Event> DisplayEvents = SQLHandle.GetDisplayEvents
                (GetCompletedEvents = false);  
            while(DisplayEvents.Count > 0) 
            {
                _Event       EventInfo = DisplayEvents.Pop();
                EventDisplay EventUI   = new EventDisplay();
                EventUI.Display(EventInfo);
                UpcomingEventsTable.Controls.Add(EventUI);
            }

            // Fill Sorted Events Gird
            DisplayEvents = SQLHandle.GetDisplayEvents
                (GetCompletedEvents = true);
            while (DisplayEvents.Count > 0)
            {
                _Event       EventInfo = DisplayEvents.Pop();
                EventDisplay EventUI     = new EventDisplay();
                EventUI.DisplayCompletedEvent(EventInfo);
                SortByTable.Controls.Add(EventUI);
            }
        }

        // ###-------------------        Event Creation        -------------------###

        /// <summary>
        /// This method is responsible for reading and evaluating the
        /// data inside of text fields related to adding information 
        /// into SQL. If the providing data is legal, than we insert
        /// the data into the SQL EventContainer.
        /// </summary>
        private void AddEventBtn_Click(object sender, EventArgs e)
        {
            // Checks the Data entered from the Date field
            if (!ValidDateFormat(out int CaseNumber))
            {
                DisplayErrorMsg(CaseNumber);
                return;
            }
            if (SQLHandle.AlreadyHasEvent(EventNameTxtBox.Text, CompletionDateTxtBx.Text)) 
            {
                MessageBox.Show("An Event with this name already exists within this month. Please try again.");
                return;
            }
            // If no priority level is estalibshed, set prio as 0 otherwise dont change it
            string ePrio = PriorityLvlTxtBox.Text == " " ? 
                ePrio = "0" : ePrio = PriorityLvlTxtBox.Text;

            // Insert Data into SQL 
            SQLHandle.InsertEvent(EventNameTxtBox.Text, EventDescTxtBox.Text,
                                  RemoveEmptyChars(CompletionDateTxtBx.Text), ePrio );
            // Clear input fields
            PriorityLvlTxtBox.Text = EventNameTxtBox.Text = 
                EventDescTxtBox.Text = CompletionDateTxtBx.Text = " ";

            // Update UI
            UpcomingEventsTable.Controls.Clear();
            DisplaySQlInfo();
        }

        private void DisplayErrorMsg(int CaseNumber) 
        {
            if(CaseNumber == 1)
                MessageBox.Show("Please fill in the Event's name and enter a valid Completion Date");
            else if (CaseNumber == 2)
                MessageBox.Show("Please fill in the Event's name");
            else if (CaseNumber == 3)
                MessageBox.Show("Invalid Date entered. Please try again.");
            else
                MessageBox.Show("Please enter Date using YYYY/MM/DD format");
            return ;
        }

        /// <summary>
        /// Empty spaces contained within the CompletionDate text box
        /// inputs will cause an error in SQL, thus these empty spaces
        /// must be removed.
        /// EX.
        ///     Correct   Format: 2022/8/24
        ///     Incorrect Format: 20 22/8/24
        /// Thus, this method will protect the user from accidently 
        /// crashing and incorrectly interacting with the program.
        /// </summary>
        /// <param name="ToUpdate"></param>
        /// <returns></returns>
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
                if(!DateFormat.IsMatch(Date))
                    Case = 1;
                Case = 2;
                return false;
            }
            if (DateFormat.IsMatch(Date))
            {
                Case = 3;
                string[] DateInfo = Date.Split('/');
                return IsLegalDate(DateInfo[0], DateInfo[1], DateInfo[2]);
            }
            // Case = 2 means there was not a match with the Date Format
            Case = 4;
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
