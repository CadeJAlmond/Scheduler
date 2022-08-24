namespace Scheduler
{
    partial class EventDisplay
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
            this.EventDateBtnLbl = new System.Windows.Forms.RadioButton();
            this.EventTitle = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // EventDateBtnLbl
            // 
            this.EventDateBtnLbl.AutoSize = true;
            this.EventDateBtnLbl.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.EventDateBtnLbl.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.EventDateBtnLbl.Location = new System.Drawing.Point(14, 20);
            this.EventDateBtnLbl.MaximumSize = new System.Drawing.Size(200, 100);
            this.EventDateBtnLbl.Name = "EventDateBtnLbl";
            this.EventDateBtnLbl.Size = new System.Drawing.Size(200, 45);
            this.EventDateBtnLbl.TabIndex = 4;
            this.EventDateBtnLbl.TabStop = true;
            this.EventDateBtnLbl.Text = "radioButton1";
            this.EventDateBtnLbl.UseVisualStyleBackColor = true;
            this.EventDateBtnLbl.CheckedChanged += new System.EventHandler(this.EventDateBtnLbl_CheckedChanged);
            // 
            // EventTitle
            // 
            this.EventTitle.AutoSize = true;
            this.EventTitle.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.EventTitle.Location = new System.Drawing.Point(186, 24);
            this.EventTitle.Name = "EventTitle";
            this.EventTitle.Size = new System.Drawing.Size(97, 41);
            this.EventTitle.TabIndex = 5;
            this.EventTitle.Text = "label1";
            // 
            // EventDisplay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(17F, 41F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.EventTitle);
            this.Controls.Add(this.EventDateBtnLbl);
            this.Name = "EventDisplay";
            this.Size = new System.Drawing.Size(726, 194);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private RadioButton EventDateBtnLbl;
        private Label EventTitle;
    }
}
