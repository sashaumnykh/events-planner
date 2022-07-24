using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EventsPlanner
{
    public partial class EditEventForm : Form
    {
        int eventId;
        public EditEventForm()
        {
            InitializeComponent();
        }

        public EditEventForm(Event ev)
        {
            InitializeComponent();
            this.eventId = ev.Id;
            this.tbEditEventName.Text = ev.Name;
            this.dtpEditEventStart.Value = (DateTime)(ev.StartDate != null ? ev.StartDate : DateTime.Now);
            this.dtpEditEventEnd.Value = (DateTime)(ev.EndDate != null ? ev.EndDate : DateTime.Now);
            this.tbEditEventInfo.Text = ev.Notes;
            this.numNotifyMinutes.Value = (int)ev.NotifyBeforeInMinutes;
        }

        private void tbEditEventName_TextChanged(object sender, EventArgs e)
        {

        }

        private void dtpEditEventStart_ValueChanged(object sender, EventArgs e)
        {

        }

        private void tbEditEventInfo_TextChanged(object sender, EventArgs e)
        {

        }

        private void numNotifyMinutes_ValueChanged(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            var updatedEvent = new Event()
            {
                Id = eventId,
                Name = tbEditEventName.Text,
                StartDate = dtpEditEventStart.Value,
                EndDate = dtpEditEventEnd.Value,
                Notes = tbEditEventInfo.Text,
                NotifyBeforeInMinutes = (int?)numNotifyMinutes.Value
            };
            Database.UpdateEvent(eventId, updatedEvent);
            this.Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
