using System.ComponentModel;

namespace Scheduler
{
    public partial class Calendar : Form
    {

        // Values for Calendar navigation
        int Day, Month, Year;
        string[] Months = {
                           "Jan", "Feb", "Mar", "Apr", "May",
                           "Jun", "Jul", "Aug", "Sep", "Oct",
                           "Nov", "Dec"};

        BackgroundWorker CalendarThread = new BackgroundWorker();
        public Calendar()
        {
            InitializeComponent();
            CalendarThread.DoWork          += CalendarThread_DoWork;
            CalendarThread.WorkerReportsProgress = true;
            CalendarThread.ProgressChanged += CalendarThread_ProgressChanged;
        }

        /// <summary>
        /// The application will find the information about the current
        /// month.
        /// </summary>
        private void Calendar_Load(object sender, EventArgs e)
        {
            // Gather Current Month Information
            DateTime CurrentDate = DateTime.Now;
            Month = CurrentDate.Month;
            Year  = CurrentDate.Year;
            Day = 1;

            if (!CalendarThread.IsBusy)
                CalendarThread.RunWorkerAsync();
        }

        /// <summary>
        ///  This method is responsible for placing the UI elements, and 
        ///  calculating month information, and placing information into
        ///  the application
        /// </summary>
        private void CalendarThread_DoWork(object? sender, DoWorkEventArgs e)
        {
            DisplayMonth(Month, Year);
        }

        /// <summary>
        /// This method is responsible for directly modifying the Calendar.
        /// We modify the Calendar if
        ///     1. The user starts the application
        ///     2. The user navigates to a previous, or following month
        ///     
        ///  These changes will directly place A
        ///     1. Placeholder object days, which need to be added to 
        ///        correctly format the Calendar.
        ///     2. Days objects representing the days of the month
        /// </summary>
        public void CalendarThread_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            if (e.ProgressPercentage == 0)
                this.CalendarGrid.Controls.Add(new EmptyDay());
            else if (e.ProgressPercentage == 100)
                CalendarMonth.Text = $"{Month}: {Months[Month - 1]} {Year}";
            else
            {
                CalendarDay NewDay = new CalendarDay();
                NewDay.AddDayLabel(Day++.ToString(), Month, Year);
                this.CalendarGrid.Controls.Add((NewDay));
            }
        }

        /// <summary>
        /// This method is responsible for using the correct API to find 
        /// the applicable information regarding the amount of days in 
        /// a given month, and the amount of padding days to format the 
        /// Calendar. Then  communicating the which object needs to be 
        /// added to the GUI
        /// </summary>
        private void DisplayMonth(int _Month, int _Year)
        {
            // Find first day of the month
            DateTime FirstDay = new DateTime(_Year, _Month, 1);

            // Find the amount of days in current month
            int DaysInMonth = DateTime.DaysInMonth(_Year, _Month);
            // Find the amount of padding days to position the starting day of the month correctly
            int PlaceHolderDays = Convert.ToInt32(FirstDay.DayOfWeek.ToString("d")) - 1;

            // Place Empty Days
            bool EmptyDaysToAdd = PlaceHolderDays > 0;
            while (EmptyDaysToAdd)
            {
                CalendarThread.ReportProgress(0);
                EmptyDaysToAdd = (--PlaceHolderDays > 0);
            }

            // Place Actual Days
            bool DaysToAdd = DaysInMonth > 0;
            while (DaysToAdd)
            {
                CalendarThread.ReportProgress(1);
                DaysToAdd = --DaysInMonth > 0;
            }

            CalendarThread.ReportProgress(100);
        }

        /// <summary>
        /// This method is responsible for incrementing or decrementing
        /// the appropriate values to display into the Calender.
        /// </summary>
        private void UpdateMonth(bool GoNextMonth, int ResetDay)
        {
            CalendarGrid.Controls.Clear();

            if (GoNextMonth)
                Month++;
            else
                Month--;

            CheckYear(GoNextMonth);
            CalendarThread.RunWorkerAsync();
        }


        /// <summary>
        /// This method ensures that the Calender will make ensure
        /// that the displayed Year, and Months are set appropriately
        /// </summary>
        private void CheckYear(bool GoNextMonth)
        {
            if (GoNextMonth && Month > 12)
            {
                Year++;
                Month = 1;
            }
            else if (Month == 0)
            {
                Year--;
                Month = 12;
            }
        }

        /// <summary>
        /// This method will display the previous month's information
        /// onto the Calendar
        /// </summary>
        private void PrevBtn_Click_1(object sender, EventArgs e)
        {
            if (!CalendarThread.IsBusy)
                UpdateMonth(false, Day = 1);
        }

        /// <summary>
        /// This method will display the next month's information
        /// onto the Calendar
        /// </summary>
        private void NextBtn_Click_1(object sender, EventArgs e)
        {
            if (!CalendarThread.IsBusy)
                UpdateMonth(true, Day = 1);
        }
    }
}
