using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace EventsPlanner
{
    public partial class NewEventForm : Form
    {
        Database db = new Database();
        public NewEventForm()
        {
            InitializeComponent();
        }

        private void lbNewEventName_Click(object sender, EventArgs e)
        {

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (tbNewEventName.Text == "")
            {
                MessageBox.Show("The name cannot be empty");
            }
            else if (!(dtpNewEventStart.Value < dtpNewEventEnd.Value))
            {
                MessageBox.Show("Event should end obly after it has started.");
            }
            else if (!isThereFreeTimeForEvent(dtpNewEventStart.Value, dtpNewEventEnd.Value))
            {
                MessageBox.Show("You already have another event on this time slot");
            }
            else
            {
                int? minutes = (int)numNotifyMinutes.Value;
                Event toAdd = new Event
                {
                    Name = tbNewEventName.Text,
                    StartDate = dtpNewEventStart.Value,
                    EndDate = dtpNewEventEnd.Value,
                    Notes = tbNewEventInfo.Text == "" ? String.Empty : tbNewEventInfo.Text,
                    NotifyBeforeInMinutes = minutes
                };
                Database.AddNewEvent(toAdd);
                this.Close();
            }
        }

        private void dtpNewEventStart_ValueChanged(object sender, EventArgs e)
        {

        }

        private bool isThereFreeTimeForEvent(DateTime StartDate, DateTime EndDate)
        {
            string StartDateSql = StartDate.ToString("yyyy-MM-dd HH:mm:ss.fff");
            string EndDateSql = EndDate.ToString("yyyy-MM-dd HH:mm:ss.fff");
            return Database.CheckIfThereIsFreeTimeForEvent(StartDateSql, EndDateSql);
        }

        private void numNotifyMinutes_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
