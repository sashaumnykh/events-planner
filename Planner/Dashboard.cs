using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Planner
{
    public partial class Dashboard : Form
    {
        List<Event> events = new List<Event>()
        {
            new Event
            {
                Id = 0,
                Name = "1st event",
                Notes = "tooo much loooopppppong decsription",
                StartDate = new DateTime(2022, 07, 17)
            },
            new Event
            {
                Id = 1,
                Name = "2nd event",
                Notes = "tooo much loooopppppong decsription",
                StartDate = new DateTime(2022, 07, 17)
            },
            new Event
            {
                Id = 2,
                Name = "3rd event",
                Notes = "tooo much loooopppppong decsription",
                StartDate = new DateTime(2022, 07, 17)
            },
            new Event
            {
                Id = 3,
                Name = "4th event",
                Notes = "tooo much loooopppppong decsription",
                StartDate = new DateTime(2022, 07, 17)
            },
        };
        public Dashboard()
        {
            InitializeComponent();
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            DisplayEvents();
        }

        private void DisplayEvents()
        {
            foreach(var ev in events)
            {
                UserControlBlank e = new UserControlBlank();
                e.PopulateEventInfo(ev);
                eventsContainer.Controls.Add(e);
            }
        }

        public void DeleteEventBtnCLick(int id)
        {
            var eventToDelete = this.events.Find(e => e.Id == id);
            this.events.Remove(eventToDelete);
        }

        private void lDashboardTitle_Click(object sender, EventArgs e)
        {

        }

        private void btnAddNewEvent_Click(object sender, EventArgs e)
        {
            NewEventForm newEventForm = new NewEventForm();
            newEventForm.Show();
        }
    }
}
