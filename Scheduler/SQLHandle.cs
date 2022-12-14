using Microsoft.Extensions.Configuration;
using System.Data.SqlClient;

namespace Scheduler
{
    // Author : Cade Almond
    // Date   : 8/3/2022
    //
    // Class Contents 
    // This class acts as a communication pathway to an SQL DB.
    // Functions in this class include
    // 1. Inserting information 
    // 2. Finding  information
    // 3. Updating information
    // 4. Deleting information 
    // In the SQL DB, which is the backbone for the entire app
    // functions. All relevamt information is saved within this
    // DB and displayed to the user.
    public class SQLHandle
    {

        // ###-------------------        SQL Connection Setup        -------------------###

        private static readonly string ConnectionString;

        static SQLHandle()
        {
            // Gather and construct the information to allow a connection to
            // a SQL DB 
            var builder = new ConfigurationBuilder();
            builder.AddUserSecrets<SQLHandle>();
            IConfigurationRoot Configuration = builder.Build();
            var DatabaseServer  = Configuration.GetSection("ServerURL");
            var DatabaseCatalog = Configuration.GetSection("DBName");
            var DatabaseUserID   = Configuration.GetSection("UserName");
            var DatabasePassword = Configuration.GetSection("DBPassword");
            ConnectionString = new SqlConnectionStringBuilder()
            {
                DataSource     = DatabaseServer.Value,
                InitialCatalog = DatabaseCatalog.Value,
                UserID   = DatabaseUserID.Value,
                Password = DatabasePassword.Value,
                ConnectTimeout = 15
            }.ConnectionString;
        }

        // ###-------------------        Inserting         -------------------###

        /// <summary>
        /// A helper method which will execute a given command
        /// </summary>
        /// <param name="CommandMsg"></param>
        private static void SQLExecuteCommand(string CommandMsg)
        {
            SqlCommand InsertCommand;
            using (SqlConnection con = new SqlConnection(ConnectionString))
            {
                con.Open();
                InsertCommand = new SqlCommand(CommandMsg, con);
                InsertCommand.ExecuteNonQuery();
            }
        }

        /// <summary>
        /// A helper method which will check for enteries in
        /// the Data-Base.
        /// </summary>
        /// <param name="CommandMsg"></param>
        private static bool SQLCheckForEntry(string EntryToCheck)
        {
            bool ReturnGuard = false;
            using (SqlConnection con = new SqlConnection(ConnectionString))
            {
                con.Open();
                using (SqlCommand command = new SqlCommand(EntryToCheck, con))
                    using (SqlDataReader reader = command.ExecuteReader())
                        while (reader.Read())
                           return reader.HasRows;
            }
            return ReturnGuard;
        }


        ///</summary>
        /// This method will insert an event into an Event Container.
        /// An Event contains a name, decription, date for completion,
        /// a priority level, creation date and a color which will be 
        /// displayed into forms such as the Calendar and Eventlist.
        ///</summary>
        public static void InsertEvent(string eName, string eDesc, string eDueDate, string ePriority)
        {
            eDueDate = FormatDate(eDueDate, out string eSearch);
            string eDate  = GetDate();
            string eColor = OptimizeColor(eSearch);
            string InsertEventInfo = "INSERT INTO EventContainer(EventName, EventDescription, " +
                         $"EventColor, EventPriority, EventCreationDate, EventDueDate, CalendarSearch," +
                         $" Completed) VALUES('{eName}', '{eDesc}', '{eColor}', {ePriority}, '{eDate}', " +
                         $"'{eDueDate}', '{eSearch}', 0)";
            SQLExecuteCommand(InsertEventInfo);
        }

        /// <summary>
        /// The format yy/mm/dd is commonnly used, but for SQL
        /// data objects the format is yy-mm-dd so this format will
        /// be changed for SQL if used in the app.
        /// </summary>
        /// <param name="DateToFormat"></param>
        /// <returns></returns>
        private static string FormatDate(string DateToFormat, out string eSearch)
        {
            DateToFormat = DateToFormat.Replace('/', '-');
            eSearch = DateToFormat.Substring(0, DateToFormat.LastIndexOf('-'));
            return DateToFormat;
        }

        /// <summary>
        /// This method will consturct the correct format (yy-mm-dd) for 
        /// the date object to place into SQL of the current day, and a
        /// second out parameter which will be year-month to be searched 
        /// in the calendar form. 
        /// </summary>
        /// <param name="eSearch"></param>
        /// <returns></returns>
        private static string GetDate()
        {
            DateTime EventDateTime = DateTime.Now;
            return   EventDateTime.ToString("yyyy-MM-dd HH:mm:ss.fff");
        }

        /// <summary>
        /// This method will generate a new color for Events. The 
        /// colors are choosen in two different ways. If no Events have
        /// occured in the desired month, than we will randomly choose 
        /// one. Otherwise, we choose the color opposite of the color 
        /// wheel, (Color Theory), or choose a random color. 
        /// </summary>
        private static string OptimizeColor(string Date)
        {
            if (FirstEventInMonth(Date))
                return ColorHandle.GetNextColor(Date);
            else
                return ColorHandle.FirstColorSelector();
        }

        /// <summary>
        /// This method will query the SQL DB, attempting to determine
        /// if any Events exist within a given month using a Date and checking
        /// if the Table has any rows. 
        /// </summary>
        private static bool FirstEventInMonth(string Date)
        {
            string GetEvents = $"SELECT * FROM EventContainer WHERE CONVERT(VARCHAR," +
                $" CalendarSearch) ='{Date}'";
            bool EventsInMonth = false;
            return SQLCheckForEntry(GetEvents);
        }

        /// <summary>
        /// This method will insert a note into the SQL DB.
        /// This note will contain a title, content, and an event
        /// connection, which these notes can be attached to a pre-
        /// established event. 
        /// </summary>
        /// <param name="nTitle"></param>
        /// <param name="nContent"></param>
        /// <param name="eConnection"></param>
        public static void InsertNote(string nTitle, string nContent, string eConnection)
        {
            string nDate = GetDate();
            string InsertNote = "INSERT INTO NotesContainer(NotesTitle, NotesContent, " +
                $"NotesDate) VALUES('{nTitle}', '{nContent}', '{nDate}')";
            SQLExecuteCommand(InsertNote);
        }

        /// <summary>
        /// This method will insert an Event into the Folder
        /// Container.
        /// </summary>
        /// <param name="fName"></param>
        /// <param name="eName"></param>
        /// <param name="eDate"></param>
        public static void InsertIntoFolder(string fName, string eName, string eDate)
        {
            string InsertToFolder = "INSERT INTO FolderContainer(FolderName, EventName, Event" +
                                     $"DueDate) VALUES('{fName}', '{eName}', '{eDate}')";
            SQLExecuteCommand(InsertToFolder);
        }

        /// <summary>
        /// This method will insert a Note into the Folder
        /// Container.
        /// </summary>
        /// <param name="fName"></param>
        /// <param name="nTitle"></param>
        public static void InsertIntoFolder(string fName, string nTitle)
        {
            bool JustInsertFolder = ( nTitle == "" );
            if (JustInsertFolder)
                nTitle = "&#xnewFold2$%";
            string InsertToFolder = "INSERT INTO FolderContainer(FolderName, NotesTitle " +
                                     $") VALUES('{fName}', '{nTitle}')";
            SQLExecuteCommand(InsertToFolder);
        }

        // ###-------------------        Searching        -------------------###

        // ###-----------  Load Enteries

        /// <summary>
        /// Returns a Stack containting Events which have been completed
        /// by the user inside of the SQL DB
        /// </summary>
        /// <returns></returns>
        public static Stack<_Event> GetDisplayEvents(bool IsCompleted)
        {
            // Can create a private helper method for this (getDisplayEvents) and GetEvents 
            Stack<_Event> EventList = new Stack<_Event>();
            string eTitle, eDate, eDesc, eColor, ePrio;
            // If we are looking for completed events, CompletionVal = 1, else = 0
            int CompletionValue = IsCompleted ? 1 : 0;
            string GetEvents = "SELECT TOP (10) * FROM EventContainer WHERE Completed =" +
                $"{CompletionValue}  ORDER BY EventCreationDate";
            using (SqlConnection con = new SqlConnection(ConnectionString))
            {
                con.Open();
                using (SqlCommand command = new SqlCommand(GetEvents, con))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            eTitle = reader["EventName"].ToString();
                            eColor = reader["EventColor"].ToString();
                            eDate = reader["EventDueDate"].ToString();
                            ePrio = reader["EventPriority"].ToString();
                            eDesc = reader["EventDescription"].ToString();
                            EventList.Push(new _Event(eTitle, eColor, eDesc, eDate, ePrio));
                        }
                    }
                }
            }
            return EventList;
        }

        /// <summary>
        /// This method will return Notes that exist within
        /// the Notes Container which are ordered by their date.
        /// </summary>
        /// <returns></returns>
        public static Stack<Note> FindNotes()
        {
            Stack<Note> Notes = new Stack<Note>();
            string nTitle, nDate, nContent;
            string GetNotes = ("SELECT TOP (10) * FROM NotesContainer ORDER BY NotesDate");
            using (SqlConnection con = new SqlConnection(ConnectionString))
            {
                con.Open();
                using (SqlCommand command = new SqlCommand(GetNotes, con))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            nTitle   = reader["NotesTitle"].ToString();
                            nContent = reader["NotesContent"].ToString();
                            nDate    = reader["NotesDate"].ToString();
                            Notes.Push(new Note(nTitle, nContent, nDate));
                        }
                    }
                }
            }
            return Notes;
        }

        /// <summary>
        /// Returns all events which are occuring within a given month.
        /// </summary>
        /// <param name="SelectedMonth"></param>
        public static Stack<_Event> GetEvents(string DateToSearch)
        {
            // Can create a private helper method for this (getDisplayEvents) and GetEvents 
            Stack<_Event> EventList = new Stack<_Event>();
            string eTitle, eDate, eDesc, eColor, ePrio;
            string GetEvents = $"SELECT * FROM EventContainer WHERE EventDueDate ='{DateToSearch}'";
            using (SqlConnection con = new SqlConnection(ConnectionString))
            {
                con.Open();
                using (SqlCommand command = new SqlCommand(GetEvents, con))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            eTitle = reader["EventName"].ToString();
                            eColor = reader["EventColor"].ToString();
                            eDate = reader["EventDueDate"].ToString();
                            ePrio = reader["EventPriority"].ToString();
                            eDesc = reader["EventDescription"].ToString();
                            EventList.Push(new _Event(eTitle, eColor, eDesc, eDate, ePrio));
                        }
                    }
                }
            }
            return EventList;
        }

        /// <summary>
        /// This helper method will return a Stack containing
        /// Events that match the FindEvents command.
        /// </summary>
        /// <param name="FindEvents"></param>
        /// <returns></returns>
        private static Stack<_Event> LoadEvents(string FindEvents)
        {
            Stack<_Event> EventList = new Stack<_Event>();
            string eTitle, eDate, eDesc, eColor, ePrio;
            using (SqlConnection con = new SqlConnection(ConnectionString))
            {
                con.Open();
                using (SqlCommand command = new SqlCommand(FindEvents, con))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            eTitle = reader["EventName"].ToString();
                            eColor = reader["EventColor"].ToString();
                            eDate = reader["EventDueDate"].ToString();
                            ePrio = reader["EventPriority"].ToString();
                            eDesc = reader["EventDescription"].ToString();
                            EventList.Push(new _Event(eTitle, eColor, eDesc, eDate, ePrio));
                        }
                    }
                }
            }
            return EventList;
        }

        /// <summary>
        /// Returns all days where events are occuring within the given month
        /// </summary>
        /// <param name="SelectedMonth"></param>
        public static HashSet<string> GetEventDays(string DateToSearch)
        {
            HashSet<string> EventList = new HashSet<string>();
            string eDate;
            string GetEvents = $"SELECT * FROM EventContainer WHERE CONVERT(VARCHAR," +
                $" CalendarSearch) ='{DateToSearch}'";
            using (SqlConnection con = new SqlConnection(ConnectionString))
            {
                con.Open();
                using (SqlCommand command = new SqlCommand(GetEvents, con))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            eDate = reader["EventDueDate"].ToString();
                            eDate = eDate.Substring(eDate.IndexOf("/") + 1);
                            eDate = eDate.Substring(0, eDate.IndexOf("/"));
                            EventList.Add(eDate);
                        }
                    }
                }
            }
            return EventList;
        }

        /// <summary>
        /// This method is used to locate the most recentley added Event
        /// to a given month. Once the event if found we add its information
        /// which will be used to generate a new color.
        /// </summary>
        /// <param name="DateToSearch"></param>
        /// <returns></returns>
        public static _Event GetLastEventInMonth(string DateToSearch)
        {
            // Should try to use a helper method to use this, and getSelectedEvent
            _Event LastEvent;
            string eTitle, eDate, eDesc, eColor, ePrio;
            eTitle = eDate = eDesc = eColor = ePrio = "";
            string GetEvents = $"SELECT TOP(1) * FROM EventContainer WHERE CONVERT(VARCHAR," +
                $" CalendarSearch) ='{DateToSearch}' ORDER BY EventCreationDate";
            using (SqlConnection con = new SqlConnection(ConnectionString))
            {
                con.Open();
                using (SqlCommand command = new SqlCommand(GetEvents, con))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            eTitle = reader["EventName"].ToString();
                            eColor = reader["EventColor"].ToString();
                            eDate = reader["EventDueDate"].ToString();
                            ePrio = reader["EventPriority"].ToString();
                            eDesc = reader["EventDescription"].ToString();
                        }
                    }
                }
            }
            return LastEvent = new _Event(eTitle, eColor, eDesc, eDate, ePrio);
        }

        /// <summary>
        /// This method returns a Stack containing all the Folders that have been added
        /// into the DB. These folders are indicated by having the NoteTitle as '&#xnewFold2$%'
        /// </summary>
        public static Stack<string> GetFolders()
        {
            string GetEvents = $"SELECT * FROM FolderContainer WHERE NotesTitle LIKE '&#xnewFold2$%'";
            Stack<string> Folders = new Stack<string>();
            string FolderName;
            using (SqlConnection con = new SqlConnection(ConnectionString))
            {
                con.Open();
                using (SqlCommand command = new SqlCommand(GetEvents, con))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            FolderName = reader["FolderName"].ToString();
                            Folders.Push(FolderName);
                        }
                    }
                }
            }
            return Folders;
        }

        /// <summary>
        /// Given a Foldername, this method will return all Events
        /// which exist within that folder.
        /// </summary>
        /// <param name="FName"></param>
        /// <returns></returns>
        public static Stack<_Event> GetFolderEvents(string FName)
        {
            Stack<_Event> EventList = new Stack<_Event>();
            string GetEvents = $"SELECT * FROM FolderContainer WHERE FolderName LIKE '{FName}' " +
                               $" AND NotesTitle is NULL";
            string EName, ESearchDate;
            EName = ESearchDate = " ";
            using (SqlConnection con = new SqlConnection(ConnectionString))
            {
                con.Open();
                using (SqlCommand command = new SqlCommand(GetEvents, con))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            EName = reader["EventName"].ToString();
                            ESearchDate = reader["EventDueDate"].ToString();
                            EventList.Push(new _Event(EName, "", "", ESearchDate, ""));
                        }
                    }
                }
            }
            return EventList;
        }

        /// <summary>
        /// Given a Foldername, this method will return all Notes
        /// which exist within that folder.
        /// </summary>
        /// <param name="FName"></param>
        /// <returns></returns>
        public static Stack<string> GetFolderNotes(string FName)
        {
            string eName;
            string GetEvents = $"SELECT * FROM FolderContainer WHERE FolderName LIKE '{FName}' " +
                               $" AND EventName is NULL";
            Stack<string> Folders = new Stack<string>();
            string FolderName;
            using (SqlConnection con = new SqlConnection(ConnectionString))
            {
                con.Open();
                using (SqlCommand command = new SqlCommand(GetEvents, con))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            FolderName = reader["NotesTitle"].ToString();
                            if(FolderName != "&#xnewFold2$%")
                                Folders.Push(FolderName);
                        }
                    }
                }
            }
            return Folders;
        }

        /// <summary>
        /// Given a Notes name, this method will return a Notes
        /// which exist within a FolderContainer and the NotesContainer.
        /// </summary>
        /// <param name="FName"></param>
        /// <returns></returns>
        public static Note getSelectedNote(string nName)
        {
            Note selectedN;
            string nTitle, nContent, nDate;
            nTitle = nContent = nDate = " ";
            string getSelectedN = $"SELECT * FROM FolderContainer AS F JOIN NotesContainer AS " +
                $"N ON N.NotesTitle LIKE F.NotesTitle WHERE F.NotesTitle LIKE '{nName}' ";
            using (SqlConnection con = new SqlConnection(ConnectionString))
            {
                con.Open();
                using (SqlCommand command = new SqlCommand(getSelectedN, con))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            nTitle = reader["NotesTitle"].ToString();
                            nContent = reader["NotesContent"].ToString();
                            nDate = reader["NotesDate"].ToString();
                        }
                    }
                }
            }
            return new Note(nTitle, nContent, nDate);
        }


        /// <summary>
        /// Given a Events name and due date, this method will return 
        /// the Event which exist within a FolderContainer and the 
        /// EventContainer.
        /// </summary>
        /// <param name="FName"></param>
        /// <returns></returns>
        public static _Event getSelectedEvents(string eName, string eDueDate)
        {
            // Should try to use a helper method to use this, and GetLastEventInMonth
            string eTitle, eDesc, eDate, ePrio, eColor;
            eTitle = eDesc = eDate = ePrio = eColor = " ";
            string getSelectedN = $"SELECT * FROM FolderContainer AS F JOIN EventContainer AS E ON E.EventName " +
                $" LIKE F.EventName WHERE F.EventName LIKE '{eName}' AND E.CalendarSearch LIKE '{eDueDate}' ";
            using (SqlConnection con = new SqlConnection(ConnectionString))
            {
                con.Open();
                using (SqlCommand command = new SqlCommand(getSelectedN, con))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            eTitle = reader["EventName"].ToString();
                            eColor = reader["EventColor"].ToString();
                            eDate = reader["EventDueDate"].ToString();
                            ePrio = reader["EventPriority"].ToString();
                            eDesc = reader["EventDescription"].ToString();

                        }
                    }
                }
            }
            return new _Event(eTitle, eColor, eDesc, eDate, ePrio);
        }
        // ###-----------  Check for Enteries

        /// <summary>
        /// This method will check is a note exists within the SQL
        /// DB with the given Note Title name. 
        /// </summary>
        /// <param name="_NoteTitle"></param>
        /// <returns></returns>
        public static bool HasNote(string _NoteTitle)
        {
            string SearchForDate = $"SELECT * FROM NotesContainer WHERE " +
                $"CONVERT(VARCHAR, NotesTitle) ='{_NoteTitle}'";
            return SQLCheckForEntry(SearchForDate);
        }

        /// <summary>
        /// Checks if the Database contains this event
        /// </summary>
        /// <param name="EName"></param>
        /// <returns></returns>
        public static bool AlreadyHasEvent(string EName, string EDate)
        {
            FormatDate(EDate, out string _EDate);
            string SearchForDate = $"SELECT * FROM EventContainer WHERE CONVERT(VARCHAR, " +
                $"EventName) ='{EName}' AND CONVERT(VARCHAR, CalendarSearch) = '{EDate}'";
            return SQLCheckForEntry(SearchForDate);
        }

        // ###-------------------        Deleting         -------------------###

        /// <summary>
        /// This method is responsible for removing Note entries
        /// from the SQL DB given a Notes name and the notes content.
        /// </summary>
        /// <param name="nTitle"></param>
        /// <param name="nContent"></param>
        public static void DeleteNote(string nTitle, string nContent)
        {
            string DeleteNote = $"DELETE FROM NotesContainer WHERE NotesTitle" +
                $" LIKE '{nTitle}' AND NotesContent LIKE '{nContent}'";
            SQLExecuteCommand(DeleteNote);
        }

        // ###-------------------        Updating         -------------------###

        /// <summary>
        /// This method will locate a pre-existing Event using a
        /// known Event Name, and DueDate, and will mark it as
        /// completed, signified by setting Completed = 1 within
        /// the SQL DB.
        /// </summary>
        /// <param name="eName"></param>
        /// <param name="eDate"></param>
        public static void UpdateEvent(string eName, string eDate) 
        {
            string UpdateEvent = "UPDATE EventContainer SET Completed = '1' WHERE " +
                $"( CONVERT(VARCHAR, EventName) = '{eName}' AND EventDueDate = '{eDate}' )";
            SQLExecuteCommand(UpdateEvent);
        }

        /// <summary>
        /// This method will locate a pre-existing Note using a 
        /// known Note Title, and updates that Notes contents within
        /// the SQL DB.
        /// </summary>
        /// <param name="NoteTitle"></param>
        /// <param name="UpdatedContent"></param>
        public static void UpdateNoteEntry(string NoteTitle, string UpdatedContent)
        {
            string UpdateNoteEntry = $"UPDATE NotesContainer SET NotesContent = '{UpdatedContent}'" +
                $" WHERE CONVERT(VARCHAR, NotesTitle) = '{NoteTitle}'";
            SQLExecuteCommand(UpdateNoteEntry);
        }
    }
}
