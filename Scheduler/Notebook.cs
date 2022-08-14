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
    public partial class Notebook : Form
    {
        // TODO SEARCH FOR PRE-EXISTING NOTES
        DataTable Notes;
        public Notebook()
        {
            InitializeComponent();

        }

        /// <summary>
        /// Established the data structures for the Notes to be 
        /// jnteracted with, and displayed within data sent to the
        /// SQL DB.
        /// </summary>
        private void Notebook_Load(object sender, EventArgs e)
        {
            Notes = new DataTable();
            Notes.Columns.Add("Title"   , typeof(String));
            Notes.Columns.Add("Messages", typeof(String));

            NoteBookGallery.DataSource = Notes;
            NoteBookGallery.Columns["Messages"].Visible = false;
            DisplaySQLInfo();
        }

        /// <summary>
        /// Updates the page from information contained within the SQL DB.
        /// </summary>
        private void DisplaySQLInfo() 
        {
            Notes.Clear();
            Stack<Note> ToAdd = SQLHandle.FindNotes();
            while(ToAdd.Count > 0) 
            { 
                Note NewNote = ToAdd.Pop();
                Notes.Rows.Add(NewNote.Name, NewNote.Content);
            }
        }

        /// <summary>
        /// Will clear the data-relevant sections which will be
        /// required for a new note to be created and saved.
        /// </summary>
        private void NewNoteBtn_Click(object sender, EventArgs e)
        {
            NoteTitleTxtBox.Clear();
            NoteMsgTxtBox  .Clear();
        }

        /// <summary>
        /// This method is responsible for gathering data to send
        /// to the SQL DB to be saved. 
        /// </summary>
        private void SaveNoteBtn_Click(object sender, EventArgs e)
        {
            if (IncompletelInput()) 
            {
                MessageBox.Show("Plesse write into Title or Content field");
                return;
            } 
            string NoteTitle = NoteTitleTxtBox.Text;
            string NoteMsg   = NoteMsgTxtBox.Text;
            SQLHandle.InsertNotes(NoteTitle, NoteMsg, "");
            DisplaySQLInfo();
        }

        private bool IncompletelInput() 
        {
            if (NoteTitleTxtBox.Text == "")
                return true;
            return NoteMsgTxtBox.Text == "";
        }

        private void ReadNoteBtn_Click(object sender, EventArgs e)
        {
            int index = NoteBookGallery.CurrentCell.RowIndex;

            if (index > -1) 
            {
                NoteTitleTxtBox.Text = Notes.Rows[index].ItemArray[0].ToString();
                NoteMsgTxtBox.Text   = Notes.Rows[index].ItemArray[1].ToString();
            }
        }

        /// <summary>
        /// This method is responsible for locating the desired note
        /// data to remove from the SQL DB. 
        /// </summary>
        private void DeleteNoteBtn_Click(object sender, EventArgs e)
        {
            string NoteTitle, NoteContent;
            int index = NoteBookGallery.CurrentCell.RowIndex;
            NoteTitle   = Notes.Rows[index].ItemArray[0].ToString();
            NoteContent = Notes.Rows[index].ItemArray[1].ToString();
            SQLHandle.DeleteNote(NoteTitle, NoteContent);
            DisplaySQLInfo();
            NoteTitleTxtBox.Clear();
            NoteMsgTxtBox  .Clear();
        }

        private void NoteBookGallery_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = NoteBookGallery.CurrentCell.RowIndex;
            
            if (index > -1)
            {
                NoteTitleTxtBox.Text = Notes.Rows[index].ItemArray[0].ToString();
                NoteTitleLbl.Text    = Notes.Rows[index].ItemArray[0].ToString();
                NoteMsgTxtBox.Text   = Notes.Rows[index].ItemArray[1].ToString();
            }
        }

        private void NoteTitleTxtBox_TextChanged(object sender, EventArgs e)
        {
            NoteTitleLbl.Text = NoteTitleTxtBox.Text;
        }
    }
}
