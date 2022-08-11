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
            string Name = ToDisplay.Name;
            char Quotes = (char) 34;
            radioButton1.Text = ToDisplay.Date;
            label1.Text = ToDisplay.Name; 
        }
    }
}
