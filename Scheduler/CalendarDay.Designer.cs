namespace Scheduler
{
    partial class CalendarDay
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
            this.DayLabel = new System.Windows.Forms.Label();
            this.EventColorPanel1 = new System.Windows.Forms.Panel();
            this.EventColorPanel2 = new System.Windows.Forms.Panel();
            this.EventLabel1 = new System.Windows.Forms.Label();
            this.EventLabel2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // DayLabel
            // 
            this.DayLabel.AutoSize = true;
            this.DayLabel.BackColor = System.Drawing.Color.Transparent;
            this.DayLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(251)))), ((int)(((byte)(146)))), ((int)(((byte)(60)))));
            this.DayLabel.Location = new System.Drawing.Point(44, 22);
            this.DayLabel.Name = "DayLabel";
            this.DayLabel.Size = new System.Drawing.Size(69, 41);
            this.DayLabel.TabIndex = 0;
            this.DayLabel.Text = "Day";
            // 
            // EventColorPanel1
            // 
            this.EventColorPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.EventColorPanel1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.EventColorPanel1.Location = new System.Drawing.Point(46, 77);
            this.EventColorPanel1.Name = "EventColorPanel1";
            this.EventColorPanel1.Size = new System.Drawing.Size(21, 40);
            this.EventColorPanel1.TabIndex = 1;
            // 
            // EventColorPanel2
            // 
            this.EventColorPanel2.BackColor = System.Drawing.Color.Cyan;
            this.EventColorPanel2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.EventColorPanel2.Location = new System.Drawing.Point(46, 133);
            this.EventColorPanel2.Name = "EventColorPanel2";
            this.EventColorPanel2.Size = new System.Drawing.Size(21, 40);
            this.EventColorPanel2.TabIndex = 2;
            // 
            // EventLabel1
            // 
            this.EventLabel1.AutoSize = true;
            this.EventLabel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(37)))));
            this.EventLabel1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.EventLabel1.Location = new System.Drawing.Point(63, 76);
            this.EventLabel1.Name = "EventLabel1";
            this.EventLabel1.Size = new System.Drawing.Size(0, 41);
            this.EventLabel1.TabIndex = 3;
            // 
            // EventLabel2
            // 
            this.EventLabel2.AutoSize = true;
            this.EventLabel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(37)))));
            this.EventLabel2.Location = new System.Drawing.Point(63, 133);
            this.EventLabel2.Name = "EventLabel2";
            this.EventLabel2.Size = new System.Drawing.Size(0, 41);
            this.EventLabel2.TabIndex = 4;
            // 
            // CalendarDay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(17F, 41F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.Controls.Add(this.EventLabel2);
            this.Controls.Add(this.EventLabel1);
            this.Controls.Add(this.EventColorPanel2);
            this.Controls.Add(this.EventColorPanel1);
            this.Controls.Add(this.DayLabel);
            this.Name = "CalendarDay";
            this.Size = new System.Drawing.Size(385, 250);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label DayLabel;
        private Panel EventColorPanel1;
        private Panel EventColorPanel2;
        private Label EventLabel1;
        private Label EventLabel2;
    }
}
