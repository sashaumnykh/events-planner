using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EventsPlanner
{
    public partial class UserControlBlank : UserControl
    {
        Database db = new Database();
        public UserControlBlank()
        {
            InitializeComponent();
        }

        public void PopulateEventInfo(Entities ev)
        {
            lEventId.Text = ev.Id.ToString();
            lEventName.Text = ev.Name;
            lEventStart.Text = ev.StartDate?.ToString();
            lEventEnd.Text = ev.EndDate?.ToString();
            lEventNotes.Text = ev.Notes;
            lMinutes.Text = ev.NotifyBeforeInMinutes.ToString();
        }

        private void lEventName_Click(object sender, EventArgs e)
        {

        }

        private void btnDeleteEvent_Click(object sender, EventArgs e)
        {
            var id = Int32.Parse(this.lEventId.Text);
            DeleteEvent(id);
        }

        public void DeleteEvent(int id)
        {
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

        private void lMinutes_Click(object sender, EventArgs e)
        {

        }
    }
}
