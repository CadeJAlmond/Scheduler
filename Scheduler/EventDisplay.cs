using System;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Scheduler
{
    public partial class EventDisplay : UserControl
    {
        public EventDisplay()
        {
            InitializeComponent();
        }

        public void Display(_Event ToDisplay) 
        {
            radioButton1.Text = ToDisplay.Date;
            label1.Text       = ToDisplay.Name; 
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (radioButton1.Checked) 
            {
                string eName = label1.Text.ToString();
                string eDate = radioButton1.Text.ToString();
                // SQLHandle.UpdateEvent(eName, eDate);
                label1.ForeColor = Color.CornflowerBlue;
            }
        }
    }
}
