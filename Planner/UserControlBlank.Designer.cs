
namespace Planner
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
            this.SuspendLayout();
            // 
            // lEventName
            // 
            this.lEventName.AutoSize = true;
            this.lEventName.Font = new System.Drawing.Font("Montserrat Subrayada", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lEventName.Location = new System.Drawing.Point(63, 27);
            this.lEventName.Name = "lEventName";
            this.lEventName.Size = new System.Drawing.Size(136, 19);
            this.lEventName.TabIndex = 0;
            this.lEventName.Text = "Name of event";
            this.lEventName.Click += new System.EventHandler(this.lEventName_Click);
            // 
            // lEventNotes
            // 
            this.lEventNotes.AutoSize = true;
            this.lEventNotes.Font = new System.Drawing.Font("Montserrat Subrayada", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lEventNotes.Location = new System.Drawing.Point(25, 254);
            this.lEventNotes.Name = "lEventNotes";
            this.lEventNotes.Size = new System.Drawing.Size(77, 14);
            this.lEventNotes.TabIndex = 1;
            this.lEventNotes.Text = "Event Info";
            // 
            // lEventStart
            // 
            this.lEventStart.AutoSize = true;
            this.lEventStart.Font = new System.Drawing.Font("Montserrat Subrayada", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lEventStart.Location = new System.Drawing.Point(18, 99);
            this.lEventStart.Name = "lEventStart";
            this.lEventStart.Size = new System.Drawing.Size(101, 19);
            this.lEventStart.TabIndex = 2;
            this.lEventStart.Text = "StartDate";
            // 
            // lEventEnd
            // 
            this.lEventEnd.AutoSize = true;
            this.lEventEnd.Font = new System.Drawing.Font("Montserrat Subrayada", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lEventEnd.Location = new System.Drawing.Point(18, 134);
            this.lEventEnd.Name = "lEventEnd";
            this.lEventEnd.Size = new System.Drawing.Size(85, 19);
            this.lEventEnd.TabIndex = 2;
            this.lEventEnd.Text = "EndDate";
            // 
            // btnEditEvent
            // 
            this.btnEditEvent.Location = new System.Drawing.Point(21, 370);
            this.btnEditEvent.Name = "btnEditEvent";
            this.btnEditEvent.Size = new System.Drawing.Size(98, 27);
            this.btnEditEvent.TabIndex = 3;
            this.btnEditEvent.Text = "Edit";
            this.btnEditEvent.UseVisualStyleBackColor = true;
            // 
            // btnDeleteEvent
            // 
            this.btnDeleteEvent.Location = new System.Drawing.Point(157, 370);
            this.btnDeleteEvent.Name = "btnDeleteEvent";
            this.btnDeleteEvent.Size = new System.Drawing.Size(98, 27);
            this.btnDeleteEvent.TabIndex = 4;
            this.btnDeleteEvent.Text = "Delete";
            this.btnDeleteEvent.UseVisualStyleBackColor = true;
            this.btnDeleteEvent.Click += new System.EventHandler(this.btnDeleteEvent_Click);
            // 
            // UserControlBlank
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.btnDeleteEvent);
            this.Controls.Add(this.btnEditEvent);
            this.Controls.Add(this.lEventEnd);
            this.Controls.Add(this.lEventStart);
            this.Controls.Add(this.lEventNotes);
            this.Controls.Add(this.lEventName);
            this.Name = "UserControlBlank";
            this.Size = new System.Drawing.Size(273, 428);
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
    }
}
