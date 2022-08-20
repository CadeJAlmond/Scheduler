namespace Scheduler
{
    partial class Calendar
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
            this.CalendarGrid = new System.Windows.Forms.TableLayoutPanel();
            this.PrevBtn = new System.Windows.Forms.Button();
            this.NextBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.CalendarMonth = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // CalendarGrid
            // 
            this.CalendarGrid.ColumnCount = 7;
            this.CalendarGrid.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.CalendarGrid.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.CalendarGrid.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.CalendarGrid.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.CalendarGrid.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.CalendarGrid.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.CalendarGrid.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.CalendarGrid.Location = new System.Drawing.Point(39, 316);
            this.CalendarGrid.Name = "CalendarGrid";
            this.CalendarGrid.RowCount = 6;
            this.CalendarGrid.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.CalendarGrid.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.CalendarGrid.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.CalendarGrid.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.CalendarGrid.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.CalendarGrid.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.CalendarGrid.Size = new System.Drawing.Size(2175, 1114);
            this.CalendarGrid.TabIndex = 0;
            // 
            // PrevBtn
            // 
            this.PrevBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PrevBtn.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.PrevBtn.Location = new System.Drawing.Point(1712, 121);
            this.PrevBtn.Name = "PrevBtn";
            this.PrevBtn.Size = new System.Drawing.Size(180, 58);
            this.PrevBtn.TabIndex = 2;
            this.PrevBtn.Text = "< Previous ";
            this.PrevBtn.UseVisualStyleBackColor = true;
            this.PrevBtn.Click += new System.EventHandler(this.PrevBtn_Click_1);
            // 
            // NextBtn
            // 
            this.NextBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.NextBtn.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.NextBtn.Location = new System.Drawing.Point(1908, 121);
            this.NextBtn.Name = "NextBtn";
            this.NextBtn.Size = new System.Drawing.Size(179, 58);
            this.NextBtn.TabIndex = 1;
            this.NextBtn.Text = "Next > ";
            this.NextBtn.UseVisualStyleBackColor = true;
            this.NextBtn.Click += new System.EventHandler(this.NextBtn_Click_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9.900001F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(1016, 244);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(155, 46);
            this.label1.TabIndex = 4;
            this.label1.Text = "Thursday";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9.900001F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(711, 244);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(193, 46);
            this.label2.TabIndex = 5;
            this.label2.Text = "Wednesday";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9.900001F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label3.Location = new System.Drawing.Point(1376, 244);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(110, 46);
            this.label3.TabIndex = 6;
            this.label3.Text = "Friday";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9.900001F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label4.Location = new System.Drawing.Point(1665, 244);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(151, 46);
            this.label4.TabIndex = 7;
            this.label4.Text = "Saturday";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9.900001F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label5.Location = new System.Drawing.Point(1994, 244);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(129, 46);
            this.label5.TabIndex = 8;
            this.label5.Text = "Sunday";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 9.900001F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label6.Location = new System.Drawing.Point(420, 244);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(142, 46);
            this.label6.TabIndex = 9;
            this.label6.Text = "Tuesday";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 9.900001F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label7.Location = new System.Drawing.Point(102, 244);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(143, 46);
            this.label7.TabIndex = 10;
            this.label7.Text = "Monday";
            // 
            // CalendarMonth
            // 
            this.CalendarMonth.AutoSize = true;
            this.CalendarMonth.Font = new System.Drawing.Font("Segoe UI Semibold", 15.1F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.CalendarMonth.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.CalendarMonth.Location = new System.Drawing.Point(1016, 121);
            this.CalendarMonth.Name = "CalendarMonth";
            this.CalendarMonth.Size = new System.Drawing.Size(184, 68);
            this.CalendarMonth.TabIndex = 3;
            this.CalendarMonth.Text = "Month";
            this.CalendarMonth.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Calendar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(17F, 41F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(23)))), ((int)(((byte)(23)))));
            this.ClientSize = new System.Drawing.Size(2291, 1442);
            this.Controls.Add(this.NextBtn);
            this.Controls.Add(this.PrevBtn);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.CalendarMonth);
            this.Controls.Add(this.CalendarGrid);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Calendar";
            this.Text = "Calendar";
            this.Load += new System.EventHandler(this.Calendar_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TableLayoutPanel CalendarGrid;
        private Button NextBtn;
        private Button PrevBtn;
        private Label CalendarMonth;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label DisplayYearLbl;
    }
}