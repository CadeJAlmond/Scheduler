namespace Scheduler
{
    public partial class MainForm : Form
    {
        string[] CurrentForm = {""};
        string NBF = "NoteBookForm";
        string CF  = "CalendarForm";
        string EF  = "EventForm";
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            CurrentForm[0] = NBF;
            MainDisplayNewForm(new EventList());
        }

        private void HeroDisplayNewForm(object SelectedForm)
        {
            Form _Form = SelectedForm as Form;
            _Form.TopLevel = false;
            _Form.Dock = DockStyle.Fill;
            _Form.Show();
        }

        private void MainDisplayNewForm(object SelectedForm) 
        { 
            Form _Form     = SelectedForm as Form;
            _Form.TopLevel = false;
            _Form.Dock     = DockStyle.Fill;
            MainDisplayForm.Controls.Clear();
            MainDisplayForm.Controls.Add  (_Form);
            _Form.Show();
        }

        /// <summary>
        /// Check if form is already on the navigated form that the user
        /// has clicked on
        /// </summary>
        private void CheckIfCurrentForm(string NavigatedForm, Form _Form) 
        {
            if (CurrentForm[0] != NavigatedForm)
                MainDisplayNewForm(_Form);
            CurrentForm[0] = NavigatedForm; 
        }

        private void EventNavigationBtn_Click(object sender, EventArgs e)
        {
            CheckIfCurrentForm(EF, new EventList());
        }

        private void CalendarNavigationBtn_Click(object sender, EventArgs e)
        {
            CheckIfCurrentForm(CF, new Calendar());
        }

        private void NoteBNavigationBtn_Click(object sender, EventArgs e)
        {
            CheckIfCurrentForm(NBF, new Notebook());
        }
    }
}