
namespace EventsPlanner
{
    partial class UserControlBlank
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lEventName = new System.Windows.Forms.Label();
            this.lEventNotes = new System.Windows.Forms.Label();
            this.lEventStart = new System.Windows.Forms.Label();
            this.lEventEnd = new System.Windows.Forms.Label();
            this.btnEditEvent = new System.Windows.Forms.Button();
            this.btnDeleteEvent = new System.Windows.Forms.Button();
            this.lEventId = new System.Windows.Forms.Label();
            this.lNotify = new System.Windows.Forms.Label();
            this.lMinutes = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lEventName
            // 
            this.lEventName.AutoSize = true;
            this.lEventName.Font = new System.Drawing.Font("Montserrat Subrayada", 11.25F, System.Drawing.FontStyle.Bold);
            this.lEventName.Location = new System.Drawing.Point(54, 23);
            this.lEventName.Name = "lEventName";
            this.lEventName.Size = new System.Drawing.Size(136, 19);
            this.lEventName.TabIndex = 0;
            this.lEventName.Text = "Name of event";
            this.lEventName.Click += new System.EventHandler(this.lEventName_Click);
            // 
            // lEventNotes
            // 
            this.lEventNotes.AutoSize = true;
            this.lEventNotes.Font = new System.Drawing.Font("Montserrat Subrayada", 8F, System.Drawing.FontStyle.Bold);
            this.lEventNotes.Location = new System.Drawing.Point(15, 219);
            this.lEventNotes.Name = "lEventNotes";
            this.lEventNotes.Size = new System.Drawing.Size(77, 14);
            this.lEventNotes.TabIndex = 1;
            this.lEventNotes.Text = "Event Info";
            // 
            // lEventStart
            // 
            this.lEventStart.AutoSize = true;
            this.lEventStart.Font = new System.Drawing.Font("Montserrat Subrayada", 11.25F, System.Drawing.FontStyle.Bold);
            this.lEventStart.Location = new System.Drawing.Point(14, 85);
            this.lEventStart.Name = "lEventStart";
            this.lEventStart.Size = new System.Drawing.Size(101, 19);
            this.lEventStart.TabIndex = 2;
            this.lEventStart.Text = "StartDate";
            // 
            // lEventEnd
            // 
            this.lEventEnd.AutoSize = true;
            this.lEventEnd.Font = new System.Drawing.Font("Montserrat Subrayada", 11.25F, System.Drawing.FontStyle.Bold);
            this.lEventEnd.Location = new System.Drawing.Point(14, 114);
            this.lEventEnd.Name = "lEventEnd";
            this.lEventEnd.Size = new System.Drawing.Size(85, 19);
            this.lEventEnd.TabIndex = 2;
            this.lEventEnd.Text = "EndDate";
            // 
            // btnEditEvent
            // 
            this.btnEditEvent.Location = new System.Drawing.Point(18, 321);
            this.btnEditEvent.Name = "btnEditEvent";
            this.btnEditEvent.Size = new System.Drawing.Size(84, 23);
            this.btnEditEvent.TabIndex = 3;
            this.btnEditEvent.Text = "Edit";
            this.btnEditEvent.UseVisualStyleBackColor = true;
            this.btnEditEvent.Click += new System.EventHandler(this.btnEditEvent_Click);
            // 
            // btnDeleteEvent
            // 
            this.btnDeleteEvent.Location = new System.Drawing.Point(135, 321);
            this.btnDeleteEvent.Name = "btnDeleteEvent";
            this.btnDeleteEvent.Size = new System.Drawing.Size(84, 23);
            this.btnDeleteEvent.TabIndex = 4;
            this.btnDeleteEvent.Text = "Delete";
            this.btnDeleteEvent.UseVisualStyleBackColor = true;
            this.btnDeleteEvent.Click += new System.EventHandler(this.btnDeleteEvent_Click);
            // 
            // lEventId
            // 
            this.lEventId.AutoSize = true;
            this.lEventId.Location = new System.Drawing.Point(116, 178);
            this.lEventId.Name = "lEventId";
            this.lEventId.Size = new System.Drawing.Size(44, 13);
            this.lEventId.TabIndex = 5;
            this.lEventId.Text = "EventId";
            this.lEventId.Visible = false;
            // 
            // lNotify
            // 
            this.lNotify.AutoSize = true;
            this.lNotify.Font = new System.Drawing.Font("Montserrat Subrayada", 8F, System.Drawing.FontStyle.Bold);
            this.lNotify.Location = new System.Drawing.Point(16, 285);
            this.lNotify.Name = "lNotify";
            this.lNotify.Size = new System.Drawing.Size(99, 14);
            this.lNotify.TabIndex = 1;
            this.lNotify.Text = "Notify before";
            // 
            // lMinutes
            // 
            this.lMinutes.AutoSize = true;
            this.lMinutes.Font = new System.Drawing.Font("Montserrat Subrayada", 8F, System.Drawing.FontStyle.Bold);
            this.lMinutes.Location = new System.Drawing.Point(116, 285);
            this.lMinutes.Name = "lMinutes";
            this.lMinutes.Size = new System.Drawing.Size(22, 14);
            this.lMinutes.TabIndex = 1;
            this.lMinutes.Text = "30";
            this.lMinutes.Click += new System.EventHandler(this.lMinutes_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Montserrat Subrayada", 8F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(160, 285);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 14);
            this.label1.TabIndex = 1;
            this.label1.Text = "minutes";
            // 
            // UserControlBlank
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.lEventId);
            this.Controls.Add(this.btnDeleteEvent);
            this.Controls.Add(this.btnEditEvent);
            this.Controls.Add(this.lEventEnd);
            this.Controls.Add(this.lEventStart);
            this.Controls.Add(this.lMinutes);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lNotify);
            this.Controls.Add(this.lEventNotes);
            this.Controls.Add(this.lEventName);
            this.Name = "UserControlBlank";
            this.Size = new System.Drawing.Size(234, 371);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lEventName;
        private System.Windows.Forms.Label lEventNotes;
        private System.Windows.Forms.Label lEventStart;
        private System.Windows.Forms.Label lEventEnd;
        private System.Windows.Forms.Button btnEditEvent;
        private System.Windows.Forms.Button btnDeleteEvent;
        private System.Windows.Forms.Label lEventId;
        private System.Windows.Forms.Label lNotify;
        private System.Windows.Forms.Label lMinutes;
        private System.Windows.Forms.Label label1;
    }
}
