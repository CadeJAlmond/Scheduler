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

        private static string FormatDate(string DateToFormat) 
        {
            return DateToFormat.Replace('/', '-');
        }

        private static string GetDate(out string eSearch)
        {
           DateTime CurrentDate = DateTime.Now;
           int Month = CurrentDate.Month;
           int Year  = CurrentDate.Year;
           int Day   = CurrentDate.Day;
           eSearch = $"{Year}-{Month}";
           return    $"{Year}-{Month}-{Day}";
        }

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

        public static bool ContainsEvent(string ToCheck) 
        {
            return false;
        }

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
                            eDate = reader["EventDueDate"].ToString();
                            eTitle = reader["EventName"].ToString();
                            eColor = reader["EventColor"].ToString();
                            ePrio = reader["EventPriority"].ToString();
                            eDesc = reader["EventDescription"].ToString();
                            EventList.Push(new _Event(eTitle, eColor, eDate, ePrio, eDesc));
                        }
                    }
                }
            }
            return EventList;
        }

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
                            eDate = reader["EventDueDate"].ToString();
                            eTitle = reader["EventName"].ToString();
                            eColor = reader["EventColor"].ToString();
                            ePrio = reader["EventPriority"].ToString();
                            eDesc = reader["EventDescription"].ToString();
                            EventList.Push(new _Event(eTitle, eColor, eDate, ePrio, eDesc));
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
                            nTitle = reader["NotesTitle"].ToString();
                            nContent = reader["NotesContent"].ToString();
                            nDate    = reader["NotesDate"].ToString();
                            Notes.Push(new Note(nTitle, nContent, nDate));
                        }
                    }
                }
            }
            return Notes;
        }

        public void ThisMonthsEvents(string SelectedMonth)
        {
        }
    }
}
