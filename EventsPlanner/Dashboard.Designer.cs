﻿
namespace EventsPlanner
{
    partial class Dashboard
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.eventsContainer = new System.Windows.Forms.FlowLayoutPanel();
            this.btnAddNewEvent = new System.Windows.Forms.Button();
            this.lDashboardTitle = new System.Windows.Forms.Label();
            this.lUpcomingEvents = new System.Windows.Forms.Label();
            this.btnRefreshDashboard = new System.Windows.Forms.Button();
            this.lEventNotification = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // eventsContainer
            // 
            this.eventsContainer.AutoScroll = true;
            this.eventsContainer.AutoSize = true;
            this.eventsContainer.Location = new System.Drawing.Point(498, 80);
            this.eventsContainer.Name = "eventsContainer";
            this.eventsContainer.Size = new System.Drawing.Size(807, 444);
            this.eventsContainer.TabIndex = 0;
            this.eventsContainer.Paint += new System.Windows.Forms.PaintEventHandler(this.eventsContainer_Paint);
            // 
            // btnAddNewEvent
            // 
            this.btnAddNewEvent.Location = new System.Drawing.Point(25, 80);
            this.btnAddNewEvent.Name = "btnAddNewEvent";
            this.btnAddNewEvent.Size = new System.Drawing.Size(168, 40);
            this.btnAddNewEvent.TabIndex = 1;
            this.btnAddNewEvent.Text = "add new event";
            this.btnAddNewEvent.UseVisualStyleBackColor = true;
            this.btnAddNewEvent.Click += new System.EventHandler(this.btnAddNewEvent_Click);
            // 
            // lDashboardTitle
            // 
            this.lDashboardTitle.AutoSize = true;
            this.lDashboardTitle.Font = new System.Drawing.Font("Montserrat Subrayada", 20F, System.Drawing.FontStyle.Bold);
            this.lDashboardTitle.Location = new System.Drawing.Point(29, 19);
            this.lDashboardTitle.Name = "lDashboardTitle";
            this.lDashboardTitle.Size = new System.Drawing.Size(321, 33);
            this.lDashboardTitle.TabIndex = 2;
            this.lDashboardTitle.Text = "Events dashboard.";
            this.lDashboardTitle.Click += new System.EventHandler(this.lDashboardTitle_Click);
            // 
            // lUpcomingEvents
            // 
            this.lUpcomingEvents.AutoSize = true;
            this.lUpcomingEvents.Font = new System.Drawing.Font("Montserrat Subrayada", 16F, System.Drawing.FontStyle.Bold);
            this.lUpcomingEvents.Location = new System.Drawing.Point(1063, 40);
            this.lUpcomingEvents.Name = "lUpcomingEvents";
            this.lUpcomingEvents.Size = new System.Drawing.Size(242, 27);
            this.lUpcomingEvents.TabIndex = 2;
            this.lUpcomingEvents.Text = "upcoming events:";
            this.lUpcomingEvents.Click += new System.EventHandler(this.lDashboardTitle_Click);
            // 
            // btnRefreshDashboard
            // 
            this.btnRefreshDashboard.Location = new System.Drawing.Point(33, 464);
            this.btnRefreshDashboard.Name = "btnRefreshDashboard";
            this.btnRefreshDashboard.Size = new System.Drawing.Size(159, 41);
            this.btnRefreshDashboard.TabIndex = 3;
            this.btnRefreshDashboard.Text = "refresh";
            this.btnRefreshDashboard.UseVisualStyleBackColor = true;
            this.btnRefreshDashboard.Click += new System.EventHandler(this.btnRefreshDashboard_Click);
            // 
            // lEventNotification
            // 
            this.lEventNotification.AutoSize = true;
            this.lEventNotification.Font = new System.Drawing.Font("Montserrat Subrayada", 12F, System.Drawing.FontStyle.Bold);
            this.lEventNotification.Location = new System.Drawing.Point(31, 158);
            this.lEventNotification.MaximumSize = new System.Drawing.Size(300, 300);
            this.lEventNotification.Name = "lEventNotification";
            this.lEventNotification.Size = new System.Drawing.Size(0, 19);
            this.lEventNotification.TabIndex = 4;
            this.lEventNotification.Click += new System.EventHandler(this.lEventNotification_Click);
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1317, 542);
            this.Controls.Add(this.lEventNotification);
            this.Controls.Add(this.btnRefreshDashboard);
            this.Controls.Add(this.lUpcomingEvents);
            this.Controls.Add(this.lDashboardTitle);
            this.Controls.Add(this.btnAddNewEvent);
            this.Controls.Add(this.eventsContainer);
            this.Name = "Dashboard";
            this.Text = "Dashboard";
            this.Load += new System.EventHandler(this.Dashboard_Load);
            this.ResumeLayout(false);
            this.PerformLayout();
            this.DisplayEvents();
        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel eventsContainer;
        private System.Windows.Forms.Button btnAddNewEvent;
        private System.Windows.Forms.Label lDashboardTitle;
        private System.Windows.Forms.Label lUpcomingEvents;
        private System.Windows.Forms.Button btnRefreshDashboard;
        private System.Windows.Forms.Label lEventNotification;
    }
}