namespace Scheduler
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            LoadNewForm(new EventList());
        }

        private void LoadNewForm(object SelectedForm) 
        { 
            Form _Form     = SelectedForm as Form;
            _Form.TopLevel = false;
            _Form.Dock     = DockStyle.Fill;
            MainDisplayForm.Controls.Clear();
            MainDisplayForm.Controls.Add  (_Form);
            _Form.Show();
        }

        private void EventNavigationBtn_Click(object sender, EventArgs e)
        {
            LoadNewForm(new EventList());
        }

        private void CalendarNavigationBtn_Click(object sender, EventArgs e)
        {
            LoadNewForm(new Calendar());
        }

        private void NoteBNavigationBtn_Click(object sender, EventArgs e)
        {
            LoadNewForm(new Notebook());
        }
    }
}