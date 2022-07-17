using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Timers;
using System.Windows.Forms;

namespace EventsPlanner
{
    public partial class Dashboard : Form
    {
        Database db = new Database();
        System.Timers.Timer notificationsTimer;
        public Dashboard()
        {
            InitializeComponent();
            notificationsTimer = new System.Timers.Timer(6000);
            notificationsTimer.Elapsed += notificationsTimer_Tick;
            notificationsTimer.Enabled = true;
        }

        private void notificationsTimer_Tick(object sender, ElapsedEventArgs e)
        {
            DateTime now = DateTime.Now;
            var events = GetEvents();
            List<DateTimeDifference> timeDifference;
            if (events.Count > 0)
            {
                timeDifference = events.Select(ev => new DateTimeDifference()
                {
                    Id = ev.Id,
                    Value = ev.StartDate?.Subtract(now).TotalMinutes,
                    Minutes = ev.NotifyBeforeInMinutes
                }).ToList();
                var toNotifyList = timeDifference.Where(td => (td.Value > 0 && td.Value < (double)td.Minutes)).OrderBy(td => td.Value).ToList();
                if (toNotifyList.Count > 0)
                {
                    Entities notificationEvent;
                    var notificationText = new StringBuilder("You have some events soon:");
                    toNotifyList.ForEach(tn => {
                        notificationEvent = events.Find(ev => ev.Id == tn.Id);
                        notificationText.Append("\n\nEvent name: " + notificationEvent.Name + "\nStarts at " + notificationEvent.StartDate);
                    });
                    if (this.lEventNotification.InvokeRequired)
                    {
                        this.lEventNotification.Invoke(new MethodInvoker(delegate {
                            lEventNotification.Text = notificationText.ToString();
                        }));
                    }
                    else
                    {
                        lEventNotification.Text = notificationText.ToString();
                    }
                }
            }
            
            var tr = true;
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            InitializeComponent();
        }

        private void DisplayEvents()
        {
            var events = GetEvents();
            foreach (var ev in events)
            {
                UserControlBlank e = new UserControlBlank();
                e.PopulateEventInfo(ev);
                eventsContainer.Controls.Add(e);
            }
        }

        public void DeleteEvent(int id)
        {
            Database.DeleteEvent(id);
        }

        public List<Entities> GetEvents()
        {
            List<Entities> res = Database.GetAllEvents();
            res = res.OrderBy(e => e.StartDate?.Date).ThenBy(e => e.EndDate?.Date).ToList();
            return res;
        }

        

        private void lDashboardTitle_Click(object sender, EventArgs e)
        {

        }

        private void btnAddNewEvent_Click(object sender, EventArgs e)
        {
            NewEventForm newEventForm = new NewEventForm();
            newEventForm.Show();
        }

        private void eventsContainer_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnRefreshDashboard_Click(object sender, EventArgs e)
        {
            this.Controls.Clear();
            this.InitializeComponent();
        }

        private void lEventNotification_Load(object sender, EventArgs e)
        {

        }

        private void lEventNotification_Click(object sender, EventArgs e)
        {

        }
    }
}
