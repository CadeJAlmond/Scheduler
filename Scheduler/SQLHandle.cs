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

        public void InsertEvent(string eName, string eDesc, string eDueDate, string ePriority) 
        {
            string eColor = "fffff";
            string eDate = GetDate();
            string eSearch = "wow";
            string InsertIDLifeSpan = "INSERT INTO EventContainer(EventName, EventDescription, " +
                         $"EventColor, EventPriority, EventCreationDate, EventDueDate, CalendarSearch, " +
                         $", Completed) VALUES({eName}, {eDesc}, {eColor}, {ePriority}, {eDate}, " +
                         $" {eDueDate}, {eSearch})";
            SqlCommand InsertCommand;
            using (SqlConnection con = new SqlConnection(ConnectionString))
            {
                con.Open();
                InsertCommand = new SqlCommand(InsertIDLifeSpan, con);
                InsertCommand.ExecuteNonQuery();
            }
        }

        private string GetDate() 
        {
            return "hu";
        }

        public void InsertNotes()
        {
            string InsertIDLifeSpan = "INSERT INTO LifeSpan(ID, LifeSpan) " +
                         $"VALUES()";
            SqlCommand InsertCommand;
            using (SqlConnection con = new SqlConnection(ConnectionString))
            {
                con.Open();
                InsertCommand = new SqlCommand(InsertIDLifeSpan, con);
                InsertCommand.ExecuteNonQuery();
            }
        }

        public bool ContainsEvent(string ToCheck) 
        {
            return false;
        }

        public void ListCompletedEvents()
        {
        }

        public void FindNotes()
        {
        }

        public void FindUncompletedEvents()
        {
        }

        public void ThisMonthsEvents(string SelectedMonth)
        {
        }
    }
}
