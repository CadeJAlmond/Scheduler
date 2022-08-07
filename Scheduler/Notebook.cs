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
        // TODO
        // ADD SQL TABLE
        // The table should act as the "Notes" 
        // ---------- OnLoad
        // on load, probe the SQL table and add all applicable contents to the 
        // Notes
        // ---------- Saving
        // Send info to SQL
        // ---------- Deleting
        // Remove info from SQL
        // ---------- Read
        // Retrieve info from SQL

        DataTable Notes;
        public Notebook()
        {
            InitializeComponent();
        }

        private void Notebook_Load(object sender, EventArgs e)
        {
            Notes = new DataTable();
            Notes.Columns.Add("Title"   , typeof(String));
            Notes.Columns.Add("Messages", typeof(String));

            NoteBookGallery.DataSource = Notes;
            NoteBookGallery.Columns["Messages"].Visible = false;
            GetSQLInfo();
        }

        // Updates the page from information contained within the SQL DB
        private void GetSQLInfo() 
        {
            Stack<Note> ToAdd = SQLHandle.FindNotes();
            while(ToAdd.Count > 0) 
            { 
                Note NewNote = ToAdd.Pop();
                Notes.Rows.Add(NewNote.Name, NewNote.Content);
            }
        }

        private void NewNoteBtn_Click(object sender, EventArgs e)
        {
            NoteTitleTxtBox.Clear();
            NoteMsgTxtBox  .Clear();
        }

        private void SaveNoteBtn_Click(object sender, EventArgs e)
        {
            string NoteTitle = NoteTitleTxtBox.Text;
            string NoteMsg   = NoteMsgTxtBox.Text;
            SQLHandle.InsertNotes(NoteTitle, NoteMsg, "");
            Notes.Clear();
            GetSQLInfo();
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

        private void DeleteNoteBtn_Click(object sender, EventArgs e)
        {
            int index = NoteBookGallery.CurrentCell.RowIndex;

            Notes.Rows[index].Delete();
        }
    }
}
