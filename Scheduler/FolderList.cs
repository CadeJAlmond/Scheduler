using System.Data;
namespace Scheduler
{
    // Author : Cade Almond
    // Date   : 10/1/2022
    //
    // Class Contents 
    // This class allows the user to
    // 1. Create folders
    // 2. Place Pre-existing Events and notes into created
    //    folders
    // 3. Display the relevant information about the Notes
    //    and Events added into folders.
    public partial class FolderList : Form
    {
        DataTable Folders;
        DataTable EDataInFolder;
        DataTable NDataInFolder;
        public FolderList()
        {
            InitializeComponent();
            // Initialize resources for the Application
            Folders      = new DataTable();
            NDataInFolder = new DataTable();
            EDataInFolder = new DataTable();
            FolderGallery.DataSource = Folders;
            EventLinkGallery.DataSource = EDataInFolder;
            NoteLinkGallery .DataSource = NDataInFolder;

            Folders      .Columns.Add("Folders", typeof(string));
            EDataInFolder.Columns.Add("Event Links", typeof(string));
            NDataInFolder.Columns.Add("Note Links" , typeof(string));

            // Customize the UI settings for the Application
            FolderGallery.Columns["Folders"].Width = 422;
            EventLinkGallery.Columns["Event Links"].Width = 410;
            NoteLinkGallery .Columns["Note Links"] .Width = 410;

            DisplayFolders();
        }

        /// <summary>
        /// This will create a new Folder within the application.
        /// </summary>
        private void NewFolderBtn_Click(object sender, EventArgs e)
        {
            string folderName = FolderNameTxtBox.Text;
            //Should check if Folder already exists
            if(folderName == folderName)
                SQLHandle.InsertIntoFolder(folderName, "");
            DisplayFolders();
        }

        /// <summary>
        /// This will establish a connection into a Folder within 
        /// the application with the provided Note or Event entered
        /// into the data-fields.
        /// </summary>
        private void AddLinkBtn_Click(object sender, EventArgs e)
        {
            int    SelectedCell = FolderGallery.CurrentCell.RowIndex;
            string FolderName   = Folders.Rows[SelectedCell].ItemArray[0].ToString();
            bool AddEvent = (EventLinkNameTxtBox.Text != string.Empty) &
                            (EventLinkDueDateTxtBox.Text != string.Empty);
            if (FolderName == "System.Data.DataRow")
                return;
            if (AddEvent)
            {
                string EventName = EventLinkNameTxtBox.Text;
                string EventDate = EventLinkDueDateTxtBox.Text;
                if(!SQLHandle.AlreadyHasEvent(EventName, EventDate))
                {
                    MessageBox.Show("Does not exist");
                    return;
                }
                SQLHandle.InsertIntoFolder(FolderName, EventName, EventDate);
            }
            else
            {
                string NoteName = NoteNameLinkTxtBox.Text;              
                if(!SQLHandle.HasNote(NoteName))
                {
                    MessageBox.Show("Does not Exist");
                    return; 
                }
                SQLHandle.InsertIntoFolder(FolderName, NoteName);
            }
        }

        /// <summary>
        /// This method will ensure that no data will be entered into
        /// the related Note data-fields, as to help the application
        /// understand what data to use.
        /// </summary>
        private void EventLinkNameTxtBox_TextChanged(object sender, EventArgs e)
        {
            CheckNoteInputFieldData();
        }

        /// <summary>
        /// This method will ensure that no data will be entered into
        /// the related Note data-fields, as to help the application
        /// understand what data to use.
        /// </summary>
        private void EventDueDateTxtBox_TextChanged(object sender, EventArgs e)
        {
            CheckNoteInputFieldData();
        }

        /// <summary>
        /// Clears the Note datta-fields
        /// </summary>
        void CheckNoteInputFieldData()
        {
            if (NoteNameLinkTxtBox.Text != "")
                NoteNameLinkTxtBox.Text = "";
        }

        /// <summary>
        /// This method will ensure that no data will be entered into
        /// the related Event data-fields, as to help the application
        /// understand what data to use.
        /// </summary>
        private void NoteNameLinkTxtBox_TextChanged(object sender, EventArgs e)
        {
            bool EventInfoIsFilledIn = (EventLinkDueDateTxtBox.Text != "") | (EventLinkNameTxtBox.Text != "");
            // Need to make sure that this is empty, so it is clear what info we are sending to SQL in the
            // Add link button, since we only want the info to one Event or Note connection
            if (EventInfoIsFilledIn)
            {
                EventLinkNameTxtBox.Text = "";
                EventLinkDueDateTxtBox.Text = "";
                return;
            }
        }

        /// <summary>
        /// This method is responsible for displaying all the existing items 
        /// that exist inside of a Folder, which has been selected.
        /// </summary>
        private void NoteBookGallery_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int    SelectedCell   = FolderGallery.CurrentCell.RowIndex;
            string SelectedFolder = Folders.Rows[SelectedCell].ItemArray[0].ToString();
            DisplayDataInfo();
        }

        /// <summary>
        /// This method is responsible for displaying the selected Event into 
        /// the link display data-fields, when an Event is selected.
        /// </summary>
        private void EventLinkGallery_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // Gather the info related to the selected Event Link
            int    SelectedCell   = EventLinkGallery.CurrentCell.RowIndex;
            string SelectedEvent = EDataInFolder.Rows[SelectedCell].ItemArray[0].ToString();
            string eName = SelectedEvent.Substring(0, SelectedEvent.LastIndexOf(" :"));
            string eDate = SelectedEvent.Substring(3 + SelectedEvent.LastIndexOf(" :"));
            // Use the contents of the Folder to search for the Event inside of the folder
            _Event ToDisplay = SQLHandle.getSelectedEvents(eName, eDate);
            // Update the link data-fields based on the generated Event 
            LinkNameLbl.Text = ToDisplay.Name;
            LinkContentTxtBox.Text = ToDisplay.Desc;
            EventLinkDueDateTxtBox.Text = ToDisplay.Date;
        }

        /// <summary>
        /// This method is responsible for displaying the selected Note into 
        /// the link display data-fields, when a Note is selected.
        /// </summary>
        private void NoteLinkGallery_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            // Gather the info related to the selected Note Link
            int SelectedCell = NoteLinkGallery.CurrentCell.RowIndex;
            string SelectedNote = NDataInFolder.Rows[SelectedCell].ItemArray[0].ToString();
            // Use the contents of the Folder to search for the Note inside of the folder
            Note ToDisplay = SQLHandle.getSelectedNote(SelectedNote);
            // Update the link data-fields
            LinkNameLbl.Text = ToDisplay.Name;
            LinkContentTxtBox.Text = ToDisplay.Content;
        }

        /// <summary>
        /// This method is responsible for displaying all the existing folders
        /// that exist to the user. Beginning on form-load.
        /// </summary>
        private void DisplayFolders()
        {
            Folders.Clear();    
            Stack<string> FoldersToAdd = SQLHandle.GetFolders();
            while(FoldersToAdd.Count > 0)
            {
                string FolderName = FoldersToAdd.Pop();
                Folders.Rows.Add(FolderName);
            }
        }

        /// <summary>
        /// This method is responsible for displaying all the existing links in
        /// the selected folder, that exist to the user when a Folder is selected.
        /// </summary>
        private void DisplayDataInfo()
        {
            int    SelectedCell = FolderGallery.CurrentCell.RowIndex;
            string FolderName   = Folders.Rows[SelectedCell].ItemArray[0].ToString();

            EDataInFolder.Clear();
            NDataInFolder.Clear();
            Stack<_Event> EventsInFolder = SQLHandle.GetFolderEvents(FolderName);
            while(EventsInFolder.Count > 0)
            {
                _Event EventLink = EventsInFolder.Pop();
                string EInfo = EventLink.Name;
                EDataInFolder.Rows.Add($"{EInfo} : {EventLink.Date}");
            }
            Stack<string> NotesInFolder  = SQLHandle.GetFolderNotes (FolderName);
            while(NotesInFolder.Count > 0)
            {
                NDataInFolder.Rows.Add(NotesInFolder.Pop());
            }
        }
    }
}
