
namespace Planner
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
            this.SuspendLayout();
            // 
            // eventsContainer
            // 
            this.eventsContainer.Location = new System.Drawing.Point(254, 92);
            this.eventsContainer.Name = "eventsContainer";
            this.eventsContainer.Size = new System.Drawing.Size(941, 512);
            this.eventsContainer.TabIndex = 0;
            // 
            // btnAddNewEvent
            // 
            this.btnAddNewEvent.Location = new System.Drawing.Point(29, 92);
            this.btnAddNewEvent.Name = "btnAddNewEvent";
            this.btnAddNewEvent.Size = new System.Drawing.Size(196, 46);
            this.btnAddNewEvent.TabIndex = 1;
            this.btnAddNewEvent.Text = "add new event";
            this.btnAddNewEvent.UseVisualStyleBackColor = true;
            this.btnAddNewEvent.Click += new System.EventHandler(this.btnAddNewEvent_Click);
            // 
            // lDashboardTitle
            // 
            this.lDashboardTitle.AutoSize = true;
            this.lDashboardTitle.Font = new System.Drawing.Font("Montserrat Subrayada", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lDashboardTitle.Location = new System.Drawing.Point(29, 18);
            this.lDashboardTitle.Name = "lDashboardTitle";
            this.lDashboardTitle.Size = new System.Drawing.Size(259, 27);
            this.lDashboardTitle.TabIndex = 2;
            this.lDashboardTitle.Text = "Events dashboard.";
            this.lDashboardTitle.Click += new System.EventHandler(this.lDashboardTitle_Click);
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1216, 625);
            this.Controls.Add(this.lDashboardTitle);
            this.Controls.Add(this.btnAddNewEvent);
            this.Controls.Add(this.eventsContainer);
            this.Name = "Dashboard";
            this.Text = "Dashboard";
            this.Load += new System.EventHandler(this.Dashboard_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel eventsContainer;
        private System.Windows.Forms.Button btnAddNewEvent;
        private System.Windows.Forms.Label lDashboardTitle;
    }
}