namespace Scheduler
{
    public partial class MainForm : Form
    {
        // Variables for form navigation
        string[] CurrentForm = {""};
        string NBF = "NoteBookForm";
        string CF  = "CalendarForm";
        string EF  = "EventForm";

        EventList EventForm    = new EventList();
        Notebook  NoteBookForm = new Notebook();
        Calendar  CalendarForm = new Calendar();

        public MainForm()
        {
            InitializeComponent();
        }

        /// <summary>
        /// The starting application will display the EventList Form once
        /// it begins
        /// </summary>
        private void MainForm_Load(object sender, EventArgs e)
        {
            CurrentForm[0] = EF;
            AddMainDisplayForm(EventForm);
        }

        /// <summary>
        /// This method will display the navigated form that the user has 
        /// requested
        /// </summary>
        /// <param name="SelectedForm"></param>
        private void AddMainDisplayForm(object SelectedForm) 
        { 
            Form Display     = SelectedForm as Form;
            Display.TopLevel = false;
            Display.Dock     = DockStyle.Fill;
            MainDisplayForm.Controls.Clear();
            MainDisplayForm.Controls.Add  (Display);
            Display.Show();
        }

        /// <summary>
        /// Check if form is already displaying the form that the user
        /// has requested to navigate to
        /// </summary>
        private void CheckIfCurrentForm(string NavigatedForm, Form _Form) 
        {
            if (CurrentForm[0] != NavigatedForm)
                AddMainDisplayForm(_Form);
            CurrentForm[0] = NavigatedForm; 
        }

        private void EventNavigationBtn_Click(object sender, EventArgs e)
        {
            CheckIfCurrentForm(EF, EventForm);
        }

        private void CalendarNavigationBtn_Click(object sender, EventArgs e)
        {
            CheckIfCurrentForm(CF, CalendarForm);
        }

        private void NoteBNavigationBtn_Click(object sender, EventArgs e)
        {
            CheckIfCurrentForm(NBF, NoteBookForm);
        }
    }
}