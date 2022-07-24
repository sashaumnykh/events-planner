
namespace EventsPlanner
{
    partial class EditEventForm
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
            this.numNotifyMinutes = new System.Windows.Forms.NumericUpDown();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.dtpEditEventEnd = new System.Windows.Forms.DateTimePicker();
            this.dtpEditEventStart = new System.Windows.Forms.DateTimePicker();
            this.lNewEventInfo = new System.Windows.Forms.Label();
            this.lMinutes = new System.Windows.Forms.Label();
            this.lNotify = new System.Windows.Forms.Label();
            this.lNewEventEnd = new System.Windows.Forms.Label();
            this.lNewEventStart = new System.Windows.Forms.Label();
            this.lbNewEventName = new System.Windows.Forms.Label();
            this.tbEditEventInfo = new System.Windows.Forms.TextBox();
            this.tbEditEventName = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.numNotifyMinutes)).BeginInit();
            this.SuspendLayout();
            // 
            // numNotifyMinutes
            // 
            this.numNotifyMinutes.Location = new System.Drawing.Point(156, 269);
            this.numNotifyMinutes.Name = "numNotifyMinutes";
            this.numNotifyMinutes.Size = new System.Drawing.Size(53, 20);
            this.numNotifyMinutes.TabIndex = 17;
            this.numNotifyMinutes.ValueChanged += new System.EventHandler(this.numNotifyMinutes_ValueChanged);
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Montserrat Subrayada", 8.249999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(185, 328);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(82, 23);
            this.btnSave.TabIndex = 15;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Font = new System.Drawing.Font("Montserrat Subrayada", 8.249999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(52, 328);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(82, 23);
            this.btnCancel.TabIndex = 16;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // dtpEditEventEnd
            // 
            this.dtpEditEventEnd.CustomFormat = "MM/dd/yyyy hh:mm";
            this.dtpEditEventEnd.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpEditEventEnd.Location = new System.Drawing.Point(54, 175);
            this.dtpEditEventEnd.Name = "dtpEditEventEnd";
            this.dtpEditEventEnd.ShowUpDown = true;
            this.dtpEditEventEnd.Size = new System.Drawing.Size(124, 20);
            this.dtpEditEventEnd.TabIndex = 13;
            // 
            // dtpEditEventStart
            // 
            this.dtpEditEventStart.CustomFormat = "MM/dd/yyyy hh:mm";
            this.dtpEditEventStart.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpEditEventStart.Location = new System.Drawing.Point(51, 112);
            this.dtpEditEventStart.Name = "dtpEditEventStart";
            this.dtpEditEventStart.ShowUpDown = true;
            this.dtpEditEventStart.Size = new System.Drawing.Size(124, 20);
            this.dtpEditEventStart.TabIndex = 14;
            this.dtpEditEventStart.ValueChanged += new System.EventHandler(this.dtpEditEventStart_ValueChanged);
            // 
            // lNewEventInfo
            // 
            this.lNewEventInfo.AutoSize = true;
            this.lNewEventInfo.Font = new System.Drawing.Font("Montserrat Subrayada", 8.249999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lNewEventInfo.Location = new System.Drawing.Point(51, 208);
            this.lNewEventInfo.Name = "lNewEventInfo";
            this.lNewEventInfo.Size = new System.Drawing.Size(125, 14);
            this.lNewEventInfo.TabIndex = 7;
            this.lNewEventInfo.Text = "Additional notes:";
            this.lNewEventInfo.UseWaitCursor = true;
            // 
            // lMinutes
            // 
            this.lMinutes.AutoSize = true;
            this.lMinutes.Font = new System.Drawing.Font("Montserrat Subrayada", 8.249999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lMinutes.Location = new System.Drawing.Point(215, 275);
            this.lMinutes.Name = "lMinutes";
            this.lMinutes.Size = new System.Drawing.Size(62, 14);
            this.lMinutes.TabIndex = 8;
            this.lMinutes.Text = "minutes.";
            // 
            // lNotify
            // 
            this.lNotify.AutoSize = true;
            this.lNotify.Font = new System.Drawing.Font("Montserrat Subrayada", 8.249999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lNotify.Location = new System.Drawing.Point(51, 275);
            this.lNotify.Name = "lNotify";
            this.lNotify.Size = new System.Drawing.Size(99, 14);
            this.lNotify.TabIndex = 9;
            this.lNotify.Text = "Notify before";
            // 
            // lNewEventEnd
            // 
            this.lNewEventEnd.AutoSize = true;
            this.lNewEventEnd.Font = new System.Drawing.Font("Montserrat Subrayada", 8.249999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lNewEventEnd.Location = new System.Drawing.Point(51, 148);
            this.lNewEventEnd.Name = "lNewEventEnd";
            this.lNewEventEnd.Size = new System.Drawing.Size(60, 14);
            this.lNewEventEnd.TabIndex = 10;
            this.lNewEventEnd.Text = "Ends at:";
            // 
            // lNewEventStart
            // 
            this.lNewEventStart.AutoSize = true;
            this.lNewEventStart.Font = new System.Drawing.Font("Montserrat Subrayada", 8.249999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lNewEventStart.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lNewEventStart.Location = new System.Drawing.Point(51, 88);
            this.lNewEventStart.Name = "lNewEventStart";
            this.lNewEventStart.Size = new System.Drawing.Size(72, 14);
            this.lNewEventStart.TabIndex = 11;
            this.lNewEventStart.Text = "Starts at:";
            // 
            // lbNewEventName
            // 
            this.lbNewEventName.AutoSize = true;
            this.lbNewEventName.Font = new System.Drawing.Font("Montserrat Subrayada", 8.249999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbNewEventName.Location = new System.Drawing.Point(51, 28);
            this.lbNewEventName.Name = "lbNewEventName";
            this.lbNewEventName.Size = new System.Drawing.Size(44, 14);
            this.lbNewEventName.TabIndex = 12;
            this.lbNewEventName.Text = "Name:";
            // 
            // tbEditEventInfo
            // 
            this.tbEditEventInfo.Location = new System.Drawing.Point(51, 233);
            this.tbEditEventInfo.Name = "tbEditEventInfo";
            this.tbEditEventInfo.Size = new System.Drawing.Size(216, 20);
            this.tbEditEventInfo.TabIndex = 5;
            this.tbEditEventInfo.TextChanged += new System.EventHandler(this.tbEditEventInfo_TextChanged);
            // 
            // tbEditEventName
            // 
            this.tbEditEventName.Location = new System.Drawing.Point(51, 52);
            this.tbEditEventName.Name = "tbEditEventName";
            this.tbEditEventName.Size = new System.Drawing.Size(216, 20);
            this.tbEditEventName.TabIndex = 6;
            this.tbEditEventName.TextChanged += new System.EventHandler(this.tbEditEventName_TextChanged);
            // 
            // EditEventForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(319, 379);
            this.Controls.Add(this.numNotifyMinutes);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.dtpEditEventEnd);
            this.Controls.Add(this.dtpEditEventStart);
            this.Controls.Add(this.lNewEventInfo);
            this.Controls.Add(this.lMinutes);
            this.Controls.Add(this.lNotify);
            this.Controls.Add(this.lNewEventEnd);
            this.Controls.Add(this.lNewEventStart);
            this.Controls.Add(this.lbNewEventName);
            this.Controls.Add(this.tbEditEventInfo);
            this.Controls.Add(this.tbEditEventName);
            this.Name = "EditEventForm";
            this.Text = "EditEventForm";
            ((System.ComponentModel.ISupportInitialize)(this.numNotifyMinutes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.NumericUpDown numNotifyMinutes;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.DateTimePicker dtpEditEventEnd;
        private System.Windows.Forms.DateTimePicker dtpEditEventStart;
        private System.Windows.Forms.Label lNewEventInfo;
        private System.Windows.Forms.Label lMinutes;
        private System.Windows.Forms.Label lNotify;
        private System.Windows.Forms.Label lNewEventEnd;
        private System.Windows.Forms.Label lNewEventStart;
        private System.Windows.Forms.Label lbNewEventName;
        private System.Windows.Forms.TextBox tbEditEventInfo;
        private System.Windows.Forms.TextBox tbEditEventName;
    }
}