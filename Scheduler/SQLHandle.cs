using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Scheduler
{
    public class SQLHandle
    {
        private static readonly string ConnectionString;

        static SQLHandle()
        {
            // Construct and gather the information to allow a connection to
            // a SQL DB 
            var builder = new ConfigurationBuilder();
            builder.AddUserSecrets<SQLHandle>();
            IConfigurationRoot Configuration = builder.Build();
            var DatabaseServer   = Configuration.GetSection("ServerURL");
            var DatabaseCatalog  = Configuration.GetSection("DBName");
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
        /// and a priority level which will be displayed in connection
        /// to the related forms.
        ///</summary>
        public static void InsertEvent(string eName, string eDesc, string eDueDate, string ePriority) 
        {
            string eColor = "fffff";
                   eDueDate = FormatDate(eDueDate);
            string eDate = GetDate(out string eSearch);
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
           int Year  = CurrentDate.Year;
           int Day   = CurrentDate.Day;
           eSearch = $"{Year}-{Month}";
           return    $"{Year}-{Month}-{Day}";
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

        public static void DeleteNote(string nTitle, string nContent)
        {
            string InsertIDLifeSpan = $"DELETE FROM NotesContainer WHERE CONVERT(VARCHAR, " +
                $"NotesTitle) ='{nTitle}' AND CONVERT(VARCHAR, NotesContent )= '{nContent}'";
            SqlCommand InsertCommand;
            using (SqlConnection con = new SqlConnection(ConnectionString))
            {
                con.Open();
                InsertCommand = new SqlCommand(InsertIDLifeSpan, con);
                InsertCommand.ExecuteNonQuery();
            }
            return;
        }

        public static bool ContainsEvent(string ToCheck) 
        {
            return false;
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
            Stack<_Event> EventList= new Stack<_Event>();
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
        /// Returns all events which are occuring within the given month
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

    }
}
