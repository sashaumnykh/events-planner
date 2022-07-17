using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Planner
{
    public partial class UserControlBlank : UserControl
    {
        public UserControlBlank()
        {
            InitializeComponent();
        }

        public void PopulateEventInfo(Event ev)
        {
            lEventName.Text = ev.Name;
            lEventStart.Text = ev.StartDate.Date.ToString();
            lEventEnd.Text = ev.EndDate.Date.ToString();
            lEventNotes.Text = ev.Notes;
            //this.btnDeleteEvent.Click += new System.EventHandler(Dashboard.DeleteEventBtnCLick);
        }

        private void lEventName_Click(object sender, EventArgs e)
        {

        }

        private void btnDeleteEvent_Click(object sender, EventArgs e)
        {
            //Dashboard.DeleteEventBtnCLick();
        }
    }
}
