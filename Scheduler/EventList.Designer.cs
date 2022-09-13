namespace Scheduler
{
    partial class EventList
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
            this.AddEventBtn = new System.Windows.Forms.Button();
            this.UpcomingEventsLbl = new System.Windows.Forms.Label();
            this.SortByLbl = new System.Windows.Forms.Label();
            this.SortByCategoryLbl = new System.Windows.Forms.Label();
            this.UpcomingEventsTable = new System.Windows.Forms.TableLayoutPanel();
            this.SortByTable = new System.Windows.Forms.TableLayoutPanel();
            this.EventNameLbl = new System.Windows.Forms.Label();
            this.EventDescLbl = new System.Windows.Forms.Label();
            this.EventCompletionDateLbl = new System.Windows.Forms.Label();
            this.EventPriorityLbl = new System.Windows.Forms.Label();
            this.EventNameTxtBox = new System.Windows.Forms.TextBox();
            this.EventDescTxtBox = new System.Windows.Forms.TextBox();
            this.CompletionDateTxtBx = new System.Windows.Forms.TextBox();
            this.PriorityLvlTxtBox = new System.Windows.Forms.TextBox();
            this.DateFormatLbl = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SORT = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // AddEventBtn
            // 
            this.AddEventBtn.BackColor = System.Drawing.Color.Transparent;
            this.AddEventBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddEventBtn.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.AddEventBtn.Location = new System.Drawing.Point(1655, 229);
            this.AddEventBtn.Name = "AddEventBtn";
            this.AddEventBtn.Size = new System.Drawing.Size(340, 90);
            this.AddEventBtn.TabIndex = 0;
            this.AddEventBtn.Text = "Add New Event";
            this.AddEventBtn.UseVisualStyleBackColor = false;
            this.AddEventBtn.Click += new System.EventHandler(this.AddEventBtn_Click);
            // 
            // UpcomingEventsLbl
            // 
            this.UpcomingEventsLbl.AutoSize = true;
            this.UpcomingEventsLbl.Font = new System.Drawing.Font("Segoe UI Semibold", 15.1F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.UpcomingEventsLbl.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.UpcomingEventsLbl.Location = new System.Drawing.Point(77, 104);
            this.UpcomingEventsLbl.Name = "UpcomingEventsLbl";
            this.UpcomingEventsLbl.Size = new System.Drawing.Size(458, 68);
            this.UpcomingEventsLbl.TabIndex = 3;
            this.UpcomingEventsLbl.Text = "Upcoming Events: ";
            // 
            // SortByLbl
            // 
            this.SortByLbl.AutoSize = true;
            this.SortByLbl.Font = new System.Drawing.Font("Segoe UI Semibold", 15.1F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.SortByLbl.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.SortByLbl.Location = new System.Drawing.Point(77, 711);
            this.SortByLbl.Name = "SortByLbl";
            this.SortByLbl.Size = new System.Drawing.Size(222, 68);
            this.SortByLbl.TabIndex = 4;
            this.SortByLbl.Text = "Sort By: ";
            // 
            // SortByCategoryLbl
            // 
            this.SortByCategoryLbl.AutoSize = true;
            this.SortByCategoryLbl.Font = new System.Drawing.Font("Segoe UI Semibold", 15.1F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.SortByCategoryLbl.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.SortByCategoryLbl.Location = new System.Drawing.Point(286, 711);
            this.SortByCategoryLbl.Name = "SortByCategoryLbl";
            this.SortByCategoryLbl.Size = new System.Drawing.Size(283, 68);
            this.SortByCategoryLbl.TabIndex = 5;
            this.SortByCategoryLbl.Text = "Completed";
            // 
            // UpcomingEventsTable
            // 
            this.UpcomingEventsTable.ColumnCount = 2;
            this.UpcomingEventsTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.UpcomingEventsTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.UpcomingEventsTable.Location = new System.Drawing.Point(77, 229);
            this.UpcomingEventsTable.Name = "UpcomingEventsTable";
            this.UpcomingEventsTable.RowCount = 5;
            this.UpcomingEventsTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.UpcomingEventsTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.UpcomingEventsTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.UpcomingEventsTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.UpcomingEventsTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.UpcomingEventsTable.Size = new System.Drawing.Size(1475, 427);
            this.UpcomingEventsTable.TabIndex = 6;
            // 
            // SortByTable
            // 
            this.SortByTable.ColumnCount = 2;
            this.SortByTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.SortByTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.SortByTable.Location = new System.Drawing.Point(88, 838);
            this.SortByTable.Name = "SortByTable";
            this.SortByTable.Padding = new System.Windows.Forms.Padding(1);
            this.SortByTable.RowCount = 5;
            this.SortByTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.SortByTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.SortByTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.SortByTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.SortByTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.SortByTable.Size = new System.Drawing.Size(1529, 462);
            this.SortByTable.TabIndex = 7;
            // 
            // EventNameLbl
            // 
            this.EventNameLbl.AutoSize = true;
            this.EventNameLbl.Font = new System.Drawing.Font("Arimo", 9.900001F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.EventNameLbl.ForeColor = System.Drawing.Color.Gainsboro;
            this.EventNameLbl.Location = new System.Drawing.Point(1655, 373);
            this.EventNameLbl.Name = "EventNameLbl";
            this.EventNameLbl.Size = new System.Drawing.Size(209, 39);
            this.EventNameLbl.TabIndex = 8;
            this.EventNameLbl.Text = "Event Name:";
            // 
            // EventDescLbl
            // 
            this.EventDescLbl.AutoSize = true;
            this.EventDescLbl.Font = new System.Drawing.Font("Arimo", 9.900001F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.EventDescLbl.ForeColor = System.Drawing.Color.Gainsboro;
            this.EventDescLbl.Location = new System.Drawing.Point(1653, 491);
            this.EventDescLbl.Name = "EventDescLbl";
            this.EventDescLbl.Size = new System.Drawing.Size(296, 39);
            this.EventDescLbl.TabIndex = 9;
            this.EventDescLbl.Text = "Event Description :";
            // 
            // EventCompletionDateLbl
            // 
            this.EventCompletionDateLbl.AutoSize = true;
            this.EventCompletionDateLbl.Font = new System.Drawing.Font("Arimo", 9.900001F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.EventCompletionDateLbl.ForeColor = System.Drawing.Color.Gainsboro;
            this.EventCompletionDateLbl.Location = new System.Drawing.Point(1653, 877);
            this.EventCompletionDateLbl.Name = "EventCompletionDateLbl";
            this.EventCompletionDateLbl.Size = new System.Drawing.Size(271, 39);
            this.EventCompletionDateLbl.TabIndex = 10;
            this.EventCompletionDateLbl.Text = "Completion Date:";
            // 
            // EventPriorityLbl
            // 
            this.EventPriorityLbl.AutoSize = true;
            this.EventPriorityLbl.Font = new System.Drawing.Font("Arimo", 9.900001F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.EventPriorityLbl.ForeColor = System.Drawing.Color.Gainsboro;
            this.EventPriorityLbl.Location = new System.Drawing.Point(1653, 1004);
            this.EventPriorityLbl.Name = "EventPriorityLbl";
            this.EventPriorityLbl.Size = new System.Drawing.Size(217, 39);
            this.EventPriorityLbl.TabIndex = 11;
            this.EventPriorityLbl.Text = "Priority Level:";
            // 
            // EventNameTxtBox
            // 
            this.EventNameTxtBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.EventNameTxtBox.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.EventNameTxtBox.Location = new System.Drawing.Point(1655, 427);
            this.EventNameTxtBox.Name = "EventNameTxtBox";
            this.EventNameTxtBox.PlaceholderText = " Name";
            this.EventNameTxtBox.Size = new System.Drawing.Size(558, 47);
            this.EventNameTxtBox.TabIndex = 12;
            // 
            // EventDescTxtBox
            // 
            this.EventDescTxtBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.EventDescTxtBox.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.EventDescTxtBox.Location = new System.Drawing.Point(1655, 542);
            this.EventDescTxtBox.Multiline = true;
            this.EventDescTxtBox.Name = "EventDescTxtBox";
            this.EventDescTxtBox.PlaceholderText = " Desc";
            this.EventDescTxtBox.Size = new System.Drawing.Size(558, 313);
            this.EventDescTxtBox.TabIndex = 13;
            // 
            // CompletionDateTxtBx
            // 
            this.CompletionDateTxtBx.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.CompletionDateTxtBx.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.CompletionDateTxtBx.Location = new System.Drawing.Point(1655, 938);
            this.CompletionDateTxtBx.Name = "CompletionDateTxtBx";
            this.CompletionDateTxtBx.PlaceholderText = " YYYY/ MM/ DD";
            this.CompletionDateTxtBx.Size = new System.Drawing.Size(558, 47);
            this.CompletionDateTxtBx.TabIndex = 14;
            // 
            // PriorityLvlTxtBox
            // 
            this.PriorityLvlTxtBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.PriorityLvlTxtBox.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.PriorityLvlTxtBox.Location = new System.Drawing.Point(1655, 1066);
            this.PriorityLvlTxtBox.Name = "PriorityLvlTxtBox";
            this.PriorityLvlTxtBox.PlaceholderText = " 0 - 10";
            this.PriorityLvlTxtBox.Size = new System.Drawing.Size(558, 47);
            this.PriorityLvlTxtBox.TabIndex = 15;
            // 
            // DateFormatLbl
            // 
            this.DateFormatLbl.AutoSize = true;
            this.DateFormatLbl.ForeColor = System.Drawing.Color.Gainsboro;
            this.DateFormatLbl.Location = new System.Drawing.Point(1930, 877);
            this.DateFormatLbl.Name = "DateFormatLbl";
            this.DateFormatLbl.Size = new System.Drawing.Size(206, 41);
            this.DateFormatLbl.TabIndex = 16;
            this.DateFormatLbl.Text = "YYYY/MM/DD";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 49.1F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(80)))));
            this.label2.Location = new System.Drawing.Point(199, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(897, 219);
            this.label2.TabIndex = 17;
            this.label2.Text = "E V E N T S";
            // 
            // SORT
            // 
            this.SORT.AutoSize = true;
            this.SORT.Font = new System.Drawing.Font("Segoe UI Semibold", 49.1F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.SORT.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(80)))));
            this.SORT.Location = new System.Drawing.Point(199, 616);
            this.SORT.Name = "SORT";
            this.SORT.Size = new System.Drawing.Size(632, 219);
            this.SORT.TabIndex = 18;
            this.SORT.Text = "S O R T";
            // 
            // EventList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(17F, 41F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(23)))), ((int)(((byte)(23)))));
            this.ClientSize = new System.Drawing.Size(2291, 1442);
            this.Controls.Add(this.DateFormatLbl);
            this.Controls.Add(this.PriorityLvlTxtBox);
            this.Controls.Add(this.CompletionDateTxtBx);
            this.Controls.Add(this.EventDescTxtBox);
            this.Controls.Add(this.EventNameTxtBox);
            this.Controls.Add(this.EventPriorityLbl);
            this.Controls.Add(this.EventCompletionDateLbl);
            this.Controls.Add(this.EventDescLbl);
            this.Controls.Add(this.EventNameLbl);
            this.Controls.Add(this.SortByTable);
            this.Controls.Add(this.UpcomingEventsTable);
            this.Controls.Add(this.SortByCategoryLbl);
            this.Controls.Add(this.SortByLbl);
            this.Controls.Add(this.UpcomingEventsLbl);
            this.Controls.Add(this.AddEventBtn);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.SORT);
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "EventList";
            this.Text = "EventHandle";
            this.Load += new System.EventHandler(this.EventList_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button AddEventBtn;
        private Label UpcomingEventsLbl;
        private Label SortByLbl;
        private Label SortByCategoryLbl;
        private TableLayoutPanel UpcomingEventsTable;
        private TableLayoutPanel SortByTable;
        private Label EventNameLbl;
        private Label EventDescLbl;
        private Label EventCompletionDateLbl;
        private Label EventPriorityLbl;
        private TextBox EventNameTxtBox;
        private TextBox EventDescTxtBox;
        private TextBox CompletionDateTxtBx;
        private TextBox PriorityLvlTxtBox;
        private Label DateFormatLbl;
        private Label label2;
        private Label SORT;
    }
}