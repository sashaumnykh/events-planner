using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace EventsPlanner
{
    class Database
    {
        SqlConnection conn = new SqlConnection(@"Data source=DESKTOP-JCFAHGC;Initial Catalog=Directum;Integrated Security=True");

        public void openConnection()
        {
            if (conn.State == System.Data.ConnectionState.Closed)
            {
                conn.Open();
            }
        }

        public void closeConnection()
        {
            if (conn.State == System.Data.ConnectionState.Open)
            {
                conn.Close();
            }
        }

        public SqlConnection getConnection()
        {
            return conn;
        }

        internal static Event GetEventById(int id) {
            Database db = new Database();
            SqlConnection conn = db.getConnection();
            conn.Open();
            String sql = $"SELECT * FROM Events WHERE Id = {id}";
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = sql;
            SqlDataReader reader = cmd.ExecuteReader();
            Event res = null;
            while (reader.Read())
            {
                res = new Event()
                {
                    Id = DBHelper.DeNullInt(reader["ID"]),
                    Name = DBHelper.DeNullString(reader["Name"]),
                    Notes = DBHelper.DeNullString(reader["AdditionalInfo"]),
                    StartDate = DBHelper.GetNullableDateTime(reader["StartDate"]),
                    EndDate = DBHelper.GetNullableDateTime(reader["EndDate"]),
                    NotifyBeforeInMinutes = DBHelper.DeNullInt(reader["NotifyBeforeInMinutes"])
                };
            }
            cmd.Dispose();
            conn.Close();
            return res;
        }

        internal static void UpdateEvent(int eventId, Event ev)
        {
            Database db = new Database();
            SqlConnection conn = db.getConnection();
            conn.Open();
            String sql = $"UPDATE Events SET Name = @Name, StartDate = @StartDate, EndDate = @EndDate, AdditionalInfo = @Notes, NotifyBeforeInMinutes = @Minutes WHERE ID = {eventId}";
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = sql;
            cmd.Parameters.AddWithValue("@Name", ev.Name);
            cmd.Parameters.AddWithValue("@Notes", ev.Notes);
            cmd.Parameters.AddWithValue("@StartDate", ev.StartDate);
            cmd.Parameters.AddWithValue("@EndDate", ev.EndDate);
            cmd.Parameters.AddWithValue("@Minutes", ev.NotifyBeforeInMinutes);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Updated");
            cmd.Dispose();
            conn.Close();
        }

        internal static void AddNewEvent(Event toAdd)
        {
            Database db = new Database();
            SqlConnection conn = db.getConnection();
            conn.Open();
            String sql = $"INSERT INTO Events (Name, StartDate, EndDate, AdditionalInfo, NotifyBeforeInMinutes) VALUES (@Name, @StartDate, @EndDate, @Notes, @Minutes)";
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = sql;
            cmd.Parameters.AddWithValue("@Name", toAdd.Name);
            cmd.Parameters.AddWithValue("@Notes", toAdd.Notes);
            cmd.Parameters.AddWithValue("@StartDate", toAdd.StartDate);
            cmd.Parameters.AddWithValue("@EndDate", toAdd.EndDate);
            cmd.Parameters.AddWithValue("@Minutes", toAdd.NotifyBeforeInMinutes);
            cmd.ExecuteNonQuery();
            MessageBox.Show("Saved");
            cmd.Dispose();
            conn.Close();
        }

        internal static bool CheckIfThereIsFreeTimeForEvent(string startDateSql, string endDateSql)
        {
            Database db = new Database();
            SqlConnection conn = db.getConnection();
            conn.Open();
            String sql = $"SELECT COUNT(*) FROM Events WHERE (StartDate < '{startDateSql}' AND EndDate > '{startDateSql}') OR (StartDate < '{endDateSql}' AND EndDate > '{endDateSql}') ";
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = sql;
            var res = cmd.ExecuteScalar();
            conn.Close();
            return (int)res < 1;
        }

        internal static List<Event> GetAllEvents()
        {
            var res = new List<Event>();
            Database db = new Database();
            SqlConnection conn = db.getConnection();
            conn.Open();
            String sql = $"SELECT * FROM Events";
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = sql;

            using (SqlDataReader reader = cmd.ExecuteReader())
            {
                while (reader.Read())
                {
                    res.Add(
                        new Event
                        {
                            Id = DBHelper.DeNullInt(reader["ID"]),
                            Name = DBHelper.DeNullString(reader["Name"]),
                            Notes = DBHelper.DeNullString(reader["AdditionalInfo"]),
                            StartDate = DBHelper.GetNullableDateTime(reader["StartDate"]),
                            EndDate = DBHelper.GetNullableDateTime(reader["EndDate"]),
                            NotifyBeforeInMinutes = DBHelper.DeNullInt(reader["NotifyBeforeInMinutes"]),
                        }
                    );
                }
            }
            cmd.Dispose();
            conn.Close();
            return res;
        }

        internal static List<Event> SearchEventsByName(string searchName)
        {
            var events = GetAllEvents();
            return events.Where(e => e.Name.ToLowerInvariant() == searchName.ToLowerInvariant()).ToList();
        }

        internal static void DeleteEvent(int id)
        {
            Database db = new Database();
            SqlConnection conn = db.getConnection();
            conn.Open();
            String sql = $"DELETE FROM Events WHERE Id = {id}";
            SqlCommand cmd = conn.CreateCommand();
            cmd.CommandText = sql;
            cmd.ExecuteNonQuery();
            MessageBox.Show("Deleted");
            cmd.Dispose();
            conn.Close();
        }
    }
}
