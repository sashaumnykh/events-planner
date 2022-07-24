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

        public void PopulateEventInfo(Event ev)
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
            Database.DeleteEvent(id);
        }

        private void lMinutes_Click(object sender, EventArgs e)
        {

        }

        private void btnEditEvent_Click(object sender, EventArgs e)
        {
            var id = Int32.Parse(this.lEventId.Text);
            var ev = Database.GetEventById(id);
            EditEventForm editEventForm = new EditEventForm(ev);
            editEventForm.Show();
        }
    }
}
