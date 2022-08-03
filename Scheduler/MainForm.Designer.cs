namespace Scheduler
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.NavigationPanel = new System.Windows.Forms.Panel();
            this.NoteBNavigationBtn = new System.Windows.Forms.Button();
            this.CalendarNavigationBtn = new System.Windows.Forms.Button();
            this.EventNavigationBtn = new System.Windows.Forms.Button();
            this.WaterMarkPanel = new System.Windows.Forms.Panel();
            this.MainDisplayForm = new System.Windows.Forms.Panel();
            this.NavigationPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // NavigationPanel
            // 
            this.NavigationPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(28)))), ((int)(((byte)(28)))));
            this.NavigationPanel.Controls.Add(this.NoteBNavigationBtn);
            this.NavigationPanel.Controls.Add(this.CalendarNavigationBtn);
            this.NavigationPanel.Controls.Add(this.EventNavigationBtn);
            this.NavigationPanel.Location = new System.Drawing.Point(-6, 81);
            this.NavigationPanel.Name = "NavigationPanel";
            this.NavigationPanel.Size = new System.Drawing.Size(458, 1547);
            this.NavigationPanel.TabIndex = 0;
            // 
            // NoteBNavigationBtn
            // 
            this.NoteBNavigationBtn.Location = new System.Drawing.Point(141, 463);
            this.NoteBNavigationBtn.Name = "NoteBNavigationBtn";
            this.NoteBNavigationBtn.Size = new System.Drawing.Size(188, 58);
            this.NoteBNavigationBtn.TabIndex = 2;
            this.NoteBNavigationBtn.Text = "Notebook";
            this.NoteBNavigationBtn.UseVisualStyleBackColor = true;
            this.NoteBNavigationBtn.Click += new System.EventHandler(this.NoteBNavigationBtn_Click);
            // 
            // CalendarNavigationBtn
            // 
            this.CalendarNavigationBtn.Location = new System.Drawing.Point(135, 368);
            this.CalendarNavigationBtn.Name = "CalendarNavigationBtn";
            this.CalendarNavigationBtn.Size = new System.Drawing.Size(188, 58);
            this.CalendarNavigationBtn.TabIndex = 1;
            this.CalendarNavigationBtn.Text = "Calendar";
            this.CalendarNavigationBtn.UseVisualStyleBackColor = true;
            this.CalendarNavigationBtn.Click += new System.EventHandler(this.CalendarNavigationBtn_Click);
            // 
            // EventNavigationBtn
            // 
            this.EventNavigationBtn.Location = new System.Drawing.Point(135, 266);
            this.EventNavigationBtn.Name = "EventNavigationBtn";
            this.EventNavigationBtn.Size = new System.Drawing.Size(188, 58);
            this.EventNavigationBtn.TabIndex = 0;
            this.EventNavigationBtn.Text = "Events";
            this.EventNavigationBtn.UseVisualStyleBackColor = true;
            this.EventNavigationBtn.Click += new System.EventHandler(this.EventNavigationBtn_Click);
            // 
            // WaterMarkPanel
            // 
            this.WaterMarkPanel.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.WaterMarkPanel.Location = new System.Drawing.Point(1, 0);
            this.WaterMarkPanel.Name = "WaterMarkPanel";
            this.WaterMarkPanel.Size = new System.Drawing.Size(2838, 82);
            this.WaterMarkPanel.TabIndex = 1;
            // 
            // MainDisplayForm
            // 
            this.MainDisplayForm.Location = new System.Drawing.Point(447, 81);
            this.MainDisplayForm.Name = "MainDisplayForm";
            this.MainDisplayForm.Size = new System.Drawing.Size(2374, 1544);
            this.MainDisplayForm.TabIndex = 3;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(17F, 41F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2824, 1622);
            this.Controls.Add(this.MainDisplayForm);
            this.Controls.Add(this.WaterMarkPanel);
            this.Controls.Add(this.NavigationPanel);
            this.Name = "MainForm";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.NavigationPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Panel NavigationPanel;
        private Panel WaterMarkPanel;
        private Panel MainDisplayForm;
        private Button CalendarNavigationBtn;
        private Button EventNavigationBtn;
        private Button NoteBNavigationBtn;
    }
}