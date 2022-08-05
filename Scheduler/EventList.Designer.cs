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
            this.label1 = new System.Windows.Forms.Label();
            this.SortByLbl = new System.Windows.Forms.Label();
            this.SortByCategoryLbl = new System.Windows.Forms.Label();
            this.ThisWeekTable = new System.Windows.Forms.TableLayoutPanel();
            this.SortByTable = new System.Windows.Forms.TableLayoutPanel();
            this.EventNameLbl = new System.Windows.Forms.Label();
            this.EventDescLbl = new System.Windows.Forms.Label();
            this.EventCompletionDateLbl = new System.Windows.Forms.Label();
            this.EventPriority = new System.Windows.Forms.Label();
            this.EventNameTxtBox = new System.Windows.Forms.TextBox();
            this.EventDescTxtBox = new System.Windows.Forms.TextBox();
            this.CompletionDateTxtBx = new System.Windows.Forms.TextBox();
            this.PriorityLvlTxtBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // AddEventBtn
            // 
            this.AddEventBtn.Location = new System.Drawing.Point(49, 161);
            this.AddEventBtn.Name = "AddEventBtn";
            this.AddEventBtn.Size = new System.Drawing.Size(303, 58);
            this.AddEventBtn.TabIndex = 0;
            this.AddEventBtn.Text = "Add New Event";
            this.AddEventBtn.UseVisualStyleBackColor = true;
            this.AddEventBtn.Click += new System.EventHandler(this.AddEventBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(858, 170);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(168, 41);
            this.label1.TabIndex = 3;
            this.label1.Text = "This Week: ";
            // 
            // SortByLbl
            // 
            this.SortByLbl.AutoSize = true;
            this.SortByLbl.Location = new System.Drawing.Point(1575, 170);
            this.SortByLbl.Name = "SortByLbl";
            this.SortByLbl.Size = new System.Drawing.Size(127, 41);
            this.SortByLbl.TabIndex = 4;
            this.SortByLbl.Text = "Sort By: ";
            // 
            // SortByCategoryLbl
            // 
            this.SortByCategoryLbl.AutoSize = true;
            this.SortByCategoryLbl.Location = new System.Drawing.Point(1708, 170);
            this.SortByCategoryLbl.Name = "SortByCategoryLbl";
            this.SortByCategoryLbl.Size = new System.Drawing.Size(166, 41);
            this.SortByCategoryLbl.TabIndex = 5;
            this.SortByCategoryLbl.Text = "Completed";
            // 
            // ThisWeekTable
            // 
            this.ThisWeekTable.ColumnCount = 1;
            this.ThisWeekTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.ThisWeekTable.Location = new System.Drawing.Point(858, 242);
            this.ThisWeekTable.Name = "ThisWeekTable";
            this.ThisWeekTable.RowCount = 10;
            this.ThisWeekTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.ThisWeekTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.ThisWeekTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.ThisWeekTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.ThisWeekTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.ThisWeekTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.ThisWeekTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.ThisWeekTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.ThisWeekTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.ThisWeekTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.ThisWeekTable.Size = new System.Drawing.Size(634, 1061);
            this.ThisWeekTable.TabIndex = 6;
            // 
            // SortByTable
            // 
            this.SortByTable.ColumnCount = 1;
            this.SortByTable.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.SortByTable.Location = new System.Drawing.Point(1563, 242);
            this.SortByTable.Name = "SortByTable";
            this.SortByTable.RowCount = 10;
            this.SortByTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.SortByTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.SortByTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.SortByTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.SortByTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.SortByTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.SortByTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.SortByTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.SortByTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.SortByTable.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 10F));
            this.SortByTable.Size = new System.Drawing.Size(624, 1061);
            this.SortByTable.TabIndex = 7;
            // 
            // EventNameLbl
            // 
            this.EventNameLbl.AutoSize = true;
            this.EventNameLbl.Location = new System.Drawing.Point(58, 273);
            this.EventNameLbl.Name = "EventNameLbl";
            this.EventNameLbl.Size = new System.Drawing.Size(184, 41);
            this.EventNameLbl.TabIndex = 8;
            this.EventNameLbl.Text = "Event Name:";
            // 
            // EventDescLbl
            // 
            this.EventDescLbl.AutoSize = true;
            this.EventDescLbl.Location = new System.Drawing.Point(56, 391);
            this.EventDescLbl.Name = "EventDescLbl";
            this.EventDescLbl.Size = new System.Drawing.Size(264, 41);
            this.EventDescLbl.TabIndex = 9;
            this.EventDescLbl.Text = "Event Description :";
            // 
            // EventCompletionDateLbl
            // 
            this.EventCompletionDateLbl.AutoSize = true;
            this.EventCompletionDateLbl.Location = new System.Drawing.Point(56, 777);
            this.EventCompletionDateLbl.Name = "EventCompletionDateLbl";
            this.EventCompletionDateLbl.Size = new System.Drawing.Size(251, 41);
            this.EventCompletionDateLbl.TabIndex = 10;
            this.EventCompletionDateLbl.Text = "Completion Date:";
            // 
            // EventPriority
            // 
            this.EventPriority.AutoSize = true;
            this.EventPriority.Location = new System.Drawing.Point(56, 904);
            this.EventPriority.Name = "EventPriority";
            this.EventPriority.Size = new System.Drawing.Size(194, 41);
            this.EventPriority.TabIndex = 11;
            this.EventPriority.Text = "Priority Level:";
            // 
            // EventNameTxtBox
            // 
            this.EventNameTxtBox.Location = new System.Drawing.Point(100, 327);
            this.EventNameTxtBox.Name = "EventNameTxtBox";
            this.EventNameTxtBox.Size = new System.Drawing.Size(558, 47);
            this.EventNameTxtBox.TabIndex = 12;
            // 
            // EventDescTxtBox
            // 
            this.EventDescTxtBox.Location = new System.Drawing.Point(100, 446);
            this.EventDescTxtBox.Multiline = true;
            this.EventDescTxtBox.Name = "EventDescTxtBox";
            this.EventDescTxtBox.Size = new System.Drawing.Size(558, 313);
            this.EventDescTxtBox.TabIndex = 13;
            // 
            // CompletionDateTxtBx
            // 
            this.CompletionDateTxtBx.Location = new System.Drawing.Point(100, 841);
            this.CompletionDateTxtBx.Name = "CompletionDateTxtBx";
            this.CompletionDateTxtBx.Size = new System.Drawing.Size(558, 47);
            this.CompletionDateTxtBx.TabIndex = 14;
            // 
            // PriorityLvlTxtBox
            // 
            this.PriorityLvlTxtBox.Location = new System.Drawing.Point(100, 968);
            this.PriorityLvlTxtBox.Name = "PriorityLvlTxtBox";
            this.PriorityLvlTxtBox.Size = new System.Drawing.Size(558, 47);
            this.PriorityLvlTxtBox.TabIndex = 15;
            // 
            // EventList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(17F, 41F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(2291, 1442);
            this.Controls.Add(this.PriorityLvlTxtBox);
            this.Controls.Add(this.CompletionDateTxtBx);
            this.Controls.Add(this.EventDescTxtBox);
            this.Controls.Add(this.EventNameTxtBox);
            this.Controls.Add(this.EventPriority);
            this.Controls.Add(this.EventCompletionDateLbl);
            this.Controls.Add(this.EventDescLbl);
            this.Controls.Add(this.EventNameLbl);
            this.Controls.Add(this.SortByTable);
            this.Controls.Add(this.ThisWeekTable);
            this.Controls.Add(this.SortByCategoryLbl);
            this.Controls.Add(this.SortByLbl);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.AddEventBtn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "EventList";
            this.Text = "EventHandle";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button AddEventBtn;
        private Label label1;
        private Label SortByLbl;
        private Label SortByCategoryLbl;
        private TableLayoutPanel ThisWeekTable;
        private TableLayoutPanel SortByTable;
        private Label EventNameLbl;
        private Label EventDescLbl;
        private Label EventCompletionDateLbl;
        private Label EventPriority;
        private TextBox EventNameTxtBox;
        private TextBox EventDescTxtBox;
        private TextBox CompletionDateTxtBx;
        private TextBox PriorityLvlTxtBox;
    }
}