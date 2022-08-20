using System.ComponentModel;
using System.Data;

namespace Scheduler
{
    public partial class Notebook : Form
    {
        BackgroundWorker NotesThread = new BackgroundWorker();
        DataTable Notes;
        public Notebook()
        {
            NotesThread.DoWork += NotesThread_DoWork;
            NotesThread.WorkerReportsProgress = true;
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
            Notes.Columns.Add("Note Title", typeof(String));
            Notes.Columns.Add("Messages"  , typeof(String));

            NoteBookGallery.DataSource = Notes;
            NoteBookGallery.Columns["Messages"  ].Visible = false;
            NoteBookGallery.Columns["Note Title"].Width   = 408;
            NotesThread.RunWorkerAsync();
        }

        /// <summary>
        /// Updates the page from information contained within the SQL DB.
        /// </summary>
        private void NotesThread_DoWork(object? sender, DoWorkEventArgs e)
        {
            Notes.Clear();
            Stack<Note> ToAdd = SQLHandle.FindNotes();
            while (ToAdd.Count > 0)
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
            // Check input fields
            if (IncompletelInput()) 
            {
                MessageBox.Show("Plesse write into Title or Content fields");
                return;
            } 
            // Gather Note Data
            string NoteTitle = NoteTitleTxtBox.Text;
            string NoteMsg   = NoteMsgTxtBox.Text;
            // Communicate to SQL
            if (!SQLHandle.HasNote(NoteTitle))
                SQLHandle.InsertNotes(NoteTitle, NoteMsg, "");
            else
                SQLHandle.UpdateNoteEntry(NoteTitle, NoteMsg);
            // Display to UI
            NotesThread.RunWorkerAsync();
        }

        /// <summary>
        /// Checks if the applicable text boxes have been left
        /// emoty by the user.
        /// </summary>
        /// <returns></returns>
        private bool IncompletelInput() 
        {
            if (NoteTitleTxtBox.Text == "")
                return true;
            return NoteMsgTxtBox.Text == "";
        }

        /// <summary>
        /// This method is responsible for locating the desired note
        /// data to remove from the SQL DB. 
        /// </summary>
        private void DeleteNoteBtn_Click(object sender, EventArgs e)
        {
            string NoteTitle, NoteContent;
            // Gather Note Data
            int SelectedCell = NoteBookGallery.CurrentCell.RowIndex;
            NoteTitle   = Notes.Rows[SelectedCell].
                ItemArray[0].ToString();
            NoteContent = Notes.Rows[SelectedCell].
                ItemArray[1].ToString();
            // Communicate to SQL
            SQLHandle.DeleteNote(NoteTitle, NoteContent);
            // Update UI
            NotesThread.RunWorkerAsync();
            NoteTitleTxtBox.Clear();
            NoteMsgTxtBox  .Clear();
        }
        
        /// <summary>
        /// This method will display the NoteBook information, that 
        /// has been clicked by the user.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void NoteBookGallery_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int Index = NoteBookGallery.CurrentCell.RowIndex;
            
            if (Index > -1)
            {
                NoteTitleTxtBox.Text = Notes.Rows[Index].ItemArray[0].ToString();
                NoteTitleLbl.Text    = Notes.Rows[Index].ItemArray[0].ToString();
                NoteMsgTxtBox.Text   = Notes.Rows[Index].ItemArray[1].ToString();
            }
        }

        /// <summary>
        /// This method will update the Dislay title while the
        /// Note title is being typed. This method is for aesthetic
        /// affect.
        /// </summary>
        private void NoteTitleTxtBox_TextChanged(object sender, EventArgs e)
        {
            NoteTitleLbl.Text = NoteTitleTxtBox.Text;
        }
    }
}
