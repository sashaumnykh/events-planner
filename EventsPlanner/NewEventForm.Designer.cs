
namespace EventsPlanner
{
    partial class NewEventForm
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
            this.tbNewEventName = new System.Windows.Forms.TextBox();
            this.tbNewEventInfo = new System.Windows.Forms.TextBox();
            this.lbNewEventName = new System.Windows.Forms.Label();
            this.lNewEventInfo = new System.Windows.Forms.Label();
            this.dtpNewEventStart = new System.Windows.Forms.DateTimePicker();
            this.lNewEventStart = new System.Windows.Forms.Label();
            this.lNewEventEnd = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.dtpNewEventEnd = new System.Windows.Forms.DateTimePicker();
            this.lNotify = new System.Windows.Forms.Label();
            this.numNotifyMinutes = new System.Windows.Forms.NumericUpDown();
            this.lMinutes = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.numNotifyMinutes)).BeginInit();
            this.SuspendLayout();
            // 
            // tbNewEventName
            // 
            this.tbNewEventName.Location = new System.Drawing.Point(43, 54);
            this.tbNewEventName.Name = "tbNewEventName";
            this.tbNewEventName.Size = new System.Drawing.Size(216, 20);
            this.tbNewEventName.TabIndex = 0;
            // 
            // tbNewEventInfo
            // 
            this.tbNewEventInfo.Location = new System.Drawing.Point(43, 235);
            this.tbNewEventInfo.Name = "tbNewEventInfo";
            this.tbNewEventInfo.Size = new System.Drawing.Size(216, 20);
            this.tbNewEventInfo.TabIndex = 0;
            // 
            // lbNewEventName
            // 
            this.lbNewEventName.AutoSize = true;
            this.lbNewEventName.Location = new System.Drawing.Point(43, 30);
            this.lbNewEventName.Name = "lbNewEventName";
            this.lbNewEventName.Size = new System.Drawing.Size(38, 13);
            this.lbNewEventName.TabIndex = 1;
            this.lbNewEventName.Text = "Name:";
            this.lbNewEventName.Click += new System.EventHandler(this.lbNewEventName_Click);
            // 
            // lNewEventInfo
            // 
            this.lNewEventInfo.AutoSize = true;
            this.lNewEventInfo.Location = new System.Drawing.Point(43, 210);
            this.lNewEventInfo.Name = "lNewEventInfo";
            this.lNewEventInfo.Size = new System.Drawing.Size(85, 13);
            this.lNewEventInfo.TabIndex = 1;
            this.lNewEventInfo.Text = "Additional notes:";
            this.lNewEventInfo.UseWaitCursor = true;
            // 
            // dtpNewEventStart
            // 
            this.dtpNewEventStart.CustomFormat = "MM/dd/yyyy hh:mm";
            this.dtpNewEventStart.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpNewEventStart.Location = new System.Drawing.Point(43, 114);
            this.dtpNewEventStart.Name = "dtpNewEventStart";
            this.dtpNewEventStart.ShowUpDown = true;
            this.dtpNewEventStart.Size = new System.Drawing.Size(124, 20);
            this.dtpNewEventStart.TabIndex = 2;
            this.dtpNewEventStart.ValueChanged += new System.EventHandler(this.dtpNewEventStart_ValueChanged);
            // 
            // lNewEventStart
            // 
            this.lNewEventStart.AutoSize = true;
            this.lNewEventStart.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lNewEventStart.Location = new System.Drawing.Point(43, 90);
            this.lNewEventStart.Name = "lNewEventStart";
            this.lNewEventStart.Size = new System.Drawing.Size(49, 13);
            this.lNewEventStart.TabIndex = 1;
            this.lNewEventStart.Text = "Starts at:";
            this.lNewEventStart.Click += new System.EventHandler(this.lbNewEventName_Click);
            // 
            // lNewEventEnd
            // 
            this.lNewEventEnd.AutoSize = true;
            this.lNewEventEnd.Location = new System.Drawing.Point(43, 150);
            this.lNewEventEnd.Name = "lNewEventEnd";
            this.lNewEventEnd.Size = new System.Drawing.Size(46, 13);
            this.lNewEventEnd.TabIndex = 1;
            this.lNewEventEnd.Text = "Ends at:";
            this.lNewEventEnd.Click += new System.EventHandler(this.lbNewEventName_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(44, 330);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(82, 23);
            this.btnCancel.TabIndex = 3;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(177, 330);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(82, 23);
            this.btnSave.TabIndex = 3;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // dtpNewEventEnd
            // 
            this.dtpNewEventEnd.CustomFormat = "MM/dd/yyyy hh:mm";
            this.dtpNewEventEnd.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpNewEventEnd.Location = new System.Drawing.Point(46, 177);
            this.dtpNewEventEnd.Name = "dtpNewEventEnd";
            this.dtpNewEventEnd.ShowUpDown = true;
            this.dtpNewEventEnd.Size = new System.Drawing.Size(124, 20);
            this.dtpNewEventEnd.TabIndex = 2;
            this.dtpNewEventEnd.ValueChanged += new System.EventHandler(this.dtpNewEventStart_ValueChanged);
            // 
            // lNotify
            // 
            this.lNotify.AutoSize = true;
            this.lNotify.Location = new System.Drawing.Point(43, 277);
            this.lNotify.Name = "lNotify";
            this.lNotify.Size = new System.Drawing.Size(67, 13);
            this.lNotify.TabIndex = 1;
            this.lNotify.Text = "Notify before";
            this.lNotify.Click += new System.EventHandler(this.lbNewEventName_Click);
            // 
            // numNotifyMinutes
            // 
            this.numNotifyMinutes.Location = new System.Drawing.Point(126, 270);
            this.numNotifyMinutes.Name = "numNotifyMinutes";
            this.numNotifyMinutes.Size = new System.Drawing.Size(53, 20);
            this.numNotifyMinutes.TabIndex = 4;
            this.numNotifyMinutes.ValueChanged += new System.EventHandler(this.numNotifyMinutes_ValueChanged);
            // 
            // lMinutes
            // 
            this.lMinutes.AutoSize = true;
            this.lMinutes.Location = new System.Drawing.Point(192, 277);
            this.lMinutes.Name = "lMinutes";
            this.lMinutes.Size = new System.Drawing.Size(46, 13);
            this.lMinutes.TabIndex = 1;
            this.lMinutes.Text = "minutes.";
            this.lMinutes.Click += new System.EventHandler(this.lbNewEventName_Click);
            // 
            // NewEventForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(319, 379);
            this.Controls.Add(this.numNotifyMinutes);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.dtpNewEventEnd);
            this.Controls.Add(this.dtpNewEventStart);
            this.Controls.Add(this.lNewEventInfo);
            this.Controls.Add(this.lMinutes);
            this.Controls.Add(this.lNotify);
            this.Controls.Add(this.lNewEventEnd);
            this.Controls.Add(this.lNewEventStart);
            this.Controls.Add(this.lbNewEventName);
            this.Controls.Add(this.tbNewEventInfo);
            this.Controls.Add(this.tbNewEventName);
            this.Name = "NewEventForm";
            this.Text = "EventForm";
            ((System.ComponentModel.ISupportInitialize)(this.numNotifyMinutes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbNewEventName;
        private System.Windows.Forms.TextBox tbNewEventInfo;
        private System.Windows.Forms.Label lbNewEventName;
        private System.Windows.Forms.Label lNewEventInfo;
        private System.Windows.Forms.DateTimePicker dtpNewEventStart;
        private System.Windows.Forms.Label lNewEventStart;
        private System.Windows.Forms.Label lNewEventEnd;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.DateTimePicker dtpNewEventEnd;
        private System.Windows.Forms.Label lNotify;
        private System.Windows.Forms.NumericUpDown numNotifyMinutes;
        private System.Windows.Forms.Label lMinutes;
    }
}