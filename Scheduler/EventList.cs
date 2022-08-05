using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Scheduler
{
    public partial class EventList : Form
    {
        public EventList()
        {
            InitializeComponent();
        }

        private void AddEventBtn_Click(object sender, EventArgs e)
        {
            SQLHandle SqlConnection = new SQLHandle();
            if (!ValidInputs(out int _Case))
            {
                if (_Case == 1)
                {
                    MessageBox.Show("1");
                }
                if (_Case == 2)
                {
                    MessageBox.Show("2");
                }
            }
            if (SqlConnection.ContainsEvent("hi") == true) 
            {
                MessageBox.Show("No");
                return;
            }
            
            SqlConnection.InsertEvent(EventNameTxtBox.Text, EventDescTxtBox.Text,
                                      CompletionDateTxtBx.Text, PriorityLvlTxtBox.Text );
        }

        private bool ValidInputs(out int Case) 
        {
            Case = 0;
            if (EventNameTxtBox.Text == "")
            {
                Case = 1;
                return false;
            }
            if (CompletionDateTxtBx.Text != "")
            {
                Case = 2;
                return false;
            }
                return false;
            return true;
        }
    }
}
