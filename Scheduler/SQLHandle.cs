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

        ///</summary>
        /// This method will insert an event into an SQL DB table.
        /// An Event contains a name, decription, date for completion,
        /// a priority level, and a color which will be displayed into 
        /// forms such as the Calendar, and Eventlist.
        ///</summary>
        public static void InsertEvent(string eName, string eDesc, string eDueDate, string ePriority)
        {
            eDueDate = FormatDate(eDueDate);
            string eDate = GetDate(out string eSearch);
            string eColor = OptimizeColor(eSearch);
            string InsertIDLifeSpan = "INSERT INTO EventContainer(EventName, EventDescription, " +
                         $"EventColor, EventPriority, EventCreationDate, EventDueDate, CalendarSearch," +
                         $" Completed) VALUES('{eName}', '{eDesc}', '{eColor}', {ePriority}, '{eDate}', " +
                         $"'{eDueDate}', '{eSearch}', 0)";
            SqlCommand InsertCommand;
            using (SqlConnection con = new SqlConnection(ConnectionString))
            {
                con.Open();
                InsertCommand = new SqlCommand(InsertIDLifeSpan, con);
                InsertCommand.ExecuteNonQuery();
            }
        }

        /// <summary>
        /// The format yy/mm/dd is commonnly used, but for SQL
        /// data objects the format is yy-mm-dd so this format will
        /// be changed for SQL if used in the app.
        /// </summary>
        /// <param name="DateToFormat"></param>
        /// <returns></returns>
        private static string FormatDate(string DateToFormat)
        {
            return DateToFormat.Replace('/', '-');
        }

        /// <summary>
        /// This method will consturct the correct format (yy-mm-dd) for 
        /// the date object to place into SQL of the current day, and a
        /// second out parameter which will be year-month to be searched 
        /// in the calendar form. 
        /// </summary>
        /// <param name="eSearch"></param>
        /// <returns></returns>
        private static string GetDate(out string eSearch)
        {
            DateTime CurrentDate = DateTime.Now;
            int Month = CurrentDate.Month;
            int Year = CurrentDate.Year;
            int Day = CurrentDate.Day;
            eSearch = $"{Year}-{Month}";
            return $"{Year}-{Month}-{Day}";
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
            using (SqlConnection con = new SqlConnection(ConnectionString))
            {
                con.Open();
                using (SqlCommand command = new SqlCommand(GetEvents, con))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            return reader.HasRows;
                        }
                    }
                }
                return EventsInMonth;
            }
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
        public static void InsertNotes(string nTitle, string nContent, string eConnection)
        {
            string nDate = GetDate(out string UnneededInfo);
            string InsertIDLifeSpan = "INSERT INTO NotesContainer(NotesTitle, NotesContent, " +
                $"NotesDate) VALUES('{nTitle}', '{nContent}', '{nDate}')";
            SqlCommand InsertCommand;
            using (SqlConnection con = new SqlConnection(ConnectionString))
            {
                con.Open();
                InsertCommand = new SqlCommand(InsertIDLifeSpan, con);
                InsertCommand.ExecuteNonQuery();
            }
        }

        /// <summary>
        /// This method is responsible for removing Note entries
        /// from the SQL DB given a Notes name and the notes content.
        /// </summary>
        /// <param name="nTitle"></param>
        /// <param name="nContent"></param>
        public static void DeleteNote(string nTitle, string nContent)
        {
            string InsertIDLifeSpan = $"DELETE FROM NotesContainer WHERE CONVERT(VARCHAR, " +
                $"NotesTitle) ='{nTitle}' AND NotesContent LIKE '{nContent}'";
            SqlCommand InsertCommand;
            using (SqlConnection con = new SqlConnection(ConnectionString))
            {
                con.Open();
                InsertCommand = new SqlCommand(InsertIDLifeSpan, con);
                InsertCommand.ExecuteNonQuery();
            }
            return;
        }

        /// <summary>
        /// Returns a Stack containting Events which have been completed
        /// by the user inside of the SQL DB
        /// </summary>
        /// <returns></returns>
        public static Stack<_Event> ListCompletedEvents()
        {
            Stack<_Event> EventList = new Stack<_Event>();
            string eTitle, eDate, eDesc, eColor, ePrio;
            string GetEvents = ("SELECT TOP (10) * FROM EventContainer WHERE Completed = 1 ORDER BY EventCreationDate");
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
        /// Returns a Stack containting Events which have been uncompleted
        /// by the user inside of the SQL DB
        /// </summary>
        public static Stack<_Event> ListUncompletedEvents()
        {
            Stack<_Event> EventList = new Stack<_Event>();
            string eTitle, eDate, eDesc, eColor, ePrio;
            string GetEvents = ("SELECT TOP (10) * FROM EventContainer WHERE Completed = 0 ORDER BY EventCreationDate");
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
        /// 
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
                            nDate = reader["NotesDate"].ToString();
                            Notes.Push(new Note(nTitle, nContent, nDate));
                        }
                    }
                }
            }
            return Notes;
        }

        /// <summary>
        /// This method is used to locate if any Events exist within a 
        /// given Year-Month timeframe given the Date to search, in the 
        /// SQL DB.
        /// </summary>
        /// <param name="DateToSearch"></param>
        /// <returns></returns>
        public static bool HasEvent(string DateToSearch)
        {
            string SearchForDate = $"SELECT * FROM EventContainer WHERE EventDueDate ='{DateToSearch}'";
            using (SqlConnection con = new SqlConnection(ConnectionString))
            {
                con.Open();
                using (SqlCommand command = new SqlCommand(SearchForDate, con))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        return reader.HasRows;
                    }
                }
            }
        }

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
            using (SqlConnection con = new SqlConnection(ConnectionString))
            {
                con.Open();
                using (SqlCommand command = new SqlCommand(SearchForDate, con))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        return reader.HasRows;
                    }
                }
            }
        }

        /// <summary>
        /// TODO
        /// </summary>
        /// <param name="EName"></param>
        /// <returns></returns>
        public static bool AlreadyHasEvent(string EName)
        {
            // SHOULD ADD A DESC, CREATION DATE, AND DUEDATE TO THIS!
            string SearchForDate = $"SELECT * FROM EventContainer WHERE CONVERT(VARCHAR, " +
                $"EventName) ='{EName}'";
            using (SqlConnection con = new SqlConnection(ConnectionString))
            {
                con.Open();
                using (SqlCommand command = new SqlCommand(SearchForDate, con))
                {
                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        return reader.HasRows;
                    }
                }
            }
        }

        /// <summary>
        /// Returns all events which are occuring within a given month.
        /// </summary>
        /// <param name="SelectedMonth"></param>
        public static Stack<_Event> GetEvents(string DateToSearch)
        {
            Stack<_Event> EventList = new Stack<_Event>();
            string eTitle, eDate, eDesc, eColor, ePrio, SearchByDate;
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
        /// This method will locate a pre-existing Event using a
        /// known Event Name, and DueDate, and will mark it as
        /// completed, signified by setting Completed = 1 within
        /// the SQL DB.
        /// </summary>
        /// <param name="eName"></param>
        /// <param name="eDate"></param>
        public static void UpdateEvent(string eName, string eDate) 
        {
            string InsertIDLifeSpan = "UPDATE EventContainer SET Completed = '1' WHERE " +
                $"( CONVERT(VARCHAR, EventName) = '{eName}' AND EventDueDate = '{eDate}' )";
            SqlCommand InsertCommand;
            using (SqlConnection con = new SqlConnection(ConnectionString))
            {
                con.Open();
                InsertCommand = new SqlCommand(InsertIDLifeSpan, con);
                InsertCommand.ExecuteNonQuery();
            }
            return;
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
            string InsertIDLifeSpan = $"UPDATE NotesContainer SET NotesContent = '{UpdatedContent}'" +
                $" WHERE CONVERT(VARCHAR, NotesTitle) = '{NoteTitle}'";
            SqlCommand InsertCommand;
            using (SqlConnection con = new SqlConnection(ConnectionString))
            {
                con.Open();
                InsertCommand = new SqlCommand(InsertIDLifeSpan, con);
                InsertCommand.ExecuteNonQuery();
            }
            return;
        }

        /// <summary>
        /// TODO
        /// </summary>
        /// <param name="Date"></param>
        public static void MarkCompletedEvents(string Date)
        {
            Stack<_Event> Events = GetEvents(Date);
            while(Events.Count > 0) 
            { 
                _Event CheckDate = Events.Pop();
                int DayInMonth = int.Parse(CheckDate.Date.Substring(0, 2));
                int CurrentDay = int.Parse(Date.Substring(0, 3));
                if (DayInMonth > CurrentDay)
                    UpdateEvent(CheckDate.Name, CheckDate.Date);
            }
        }
    }
}
