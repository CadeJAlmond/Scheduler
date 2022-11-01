namespace Scheduler
{
    partial class FolderList
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            this.GolderLbl = new System.Windows.Forms.Label();
            this.NewFolderBtn = new System.Windows.Forms.Button();
            this.FolderGallery = new System.Windows.Forms.DataGridView();
            this.EventLinkGallery = new System.Windows.Forms.DataGridView();
            this.FolderNameTxtBox = new System.Windows.Forms.TextBox();
            this.FolderLinkLbl = new System.Windows.Forms.Label();
            this.AddLinkBtn = new System.Windows.Forms.Button();
            this.EventLinkNameTxtBox = new System.Windows.Forms.TextBox();
            this.NoteNameLinkTxtBox = new System.Windows.Forms.TextBox();
            this.EventFolderLinkLbl = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.EventLinkDueDateTxtBox = new System.Windows.Forms.TextBox();
            this.SelectedFolderLbl = new System.Windows.Forms.Label();
            this.LinkNameLbl = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.LinkContentTxtBox = new System.Windows.Forms.TextBox();
            this.DueDateLbl = new System.Windows.Forms.Label();
            this.DueDateAddLbl = new System.Windows.Forms.Label();
            this.MainFolderLbl = new System.Windows.Forms.Label();
            this.NoteLinkGallery = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.FolderGallery)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EventLinkGallery)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.NoteLinkGallery)).BeginInit();
            this.SuspendLayout();
            // 
            // GolderLbl
            // 
            this.GolderLbl.AutoSize = true;
            this.GolderLbl.Font = new System.Drawing.Font("Arimo", 9.900001F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.GolderLbl.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.GolderLbl.Location = new System.Drawing.Point(83, 407);
            this.GolderLbl.Name = "GolderLbl";
            this.GolderLbl.Size = new System.Drawing.Size(229, 39);
            this.GolderLbl.TabIndex = 0;
            this.GolderLbl.Text = "Your Folders : ";
            // 
            // NewFolderBtn
            // 
            this.NewFolderBtn.BackColor = System.Drawing.Color.Transparent;
            this.NewFolderBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.NewFolderBtn.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.NewFolderBtn.Location = new System.Drawing.Point(83, 294);
            this.NewFolderBtn.Name = "NewFolderBtn";
            this.NewFolderBtn.Size = new System.Drawing.Size(423, 81);
            this.NewFolderBtn.TabIndex = 1;
            this.NewFolderBtn.Text = "Add Folder";
            this.NewFolderBtn.UseVisualStyleBackColor = true;
            this.NewFolderBtn.Click += new System.EventHandler(this.NewFolderBtn_Click);
            // 
            // FolderGallery
            // 
            this.FolderGallery.AllowUserToAddRows = false;
            this.FolderGallery.AllowUserToDeleteRows = false;
            this.FolderGallery.AllowUserToResizeColumns = false;
            this.FolderGallery.AllowUserToResizeRows = false;
            this.FolderGallery.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(35)))), ((int)(((byte)(38)))));
            this.FolderGallery.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.FolderGallery.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.FolderGallery.ColumnHeadersVisible = false;
            this.FolderGallery.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(55)))), ((int)(((byte)(71)))));
            this.FolderGallery.Location = new System.Drawing.Point(83, 472);
            this.FolderGallery.Name = "FolderGallery";
            this.FolderGallery.RowHeadersVisible = false;
            this.FolderGallery.RowHeadersWidth = 102;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(55)))), ((int)(((byte)(71)))));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(78)))), ((int)(((byte)(94)))));
            this.FolderGallery.RowsDefaultCellStyle = dataGridViewCellStyle1;
            this.FolderGallery.RowTemplate.Height = 49;
            this.FolderGallery.Size = new System.Drawing.Size(423, 753);
            this.FolderGallery.TabIndex = 2;
            this.FolderGallery.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.NoteBookGallery_CellClick);
            // 
            // EventLinkGallery
            // 
            this.EventLinkGallery.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(35)))), ((int)(((byte)(38)))));
            this.EventLinkGallery.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.AppWorkspace;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.EventLinkGallery.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.EventLinkGallery.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.EventLinkGallery.ColumnHeadersVisible = false;
            this.EventLinkGallery.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(55)))), ((int)(((byte)(71)))));
            this.EventLinkGallery.Location = new System.Drawing.Point(601, 568);
            this.EventLinkGallery.Name = "EventLinkGallery";
            this.EventLinkGallery.RowHeadersVisible = false;
            this.EventLinkGallery.RowHeadersWidth = 102;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(55)))), ((int)(((byte)(71)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(78)))), ((int)(((byte)(94)))));
            this.EventLinkGallery.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.EventLinkGallery.RowTemplate.Height = 49;
            this.EventLinkGallery.Size = new System.Drawing.Size(415, 301);
            this.EventLinkGallery.TabIndex = 3;
            this.EventLinkGallery.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.EventLinkGallery_CellClick);
            // 
            // FolderNameTxtBox
            // 
            this.FolderNameTxtBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.FolderNameTxtBox.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.FolderNameTxtBox.Location = new System.Drawing.Point(83, 218);
            this.FolderNameTxtBox.Name = "FolderNameTxtBox";
            this.FolderNameTxtBox.PlaceholderText = " Folder Name";
            this.FolderNameTxtBox.Size = new System.Drawing.Size(423, 47);
            this.FolderNameTxtBox.TabIndex = 4;
            // 
            // FolderLinkLbl
            // 
            this.FolderLinkLbl.AutoSize = true;
            this.FolderLinkLbl.Font = new System.Drawing.Font("Segoe UI Semibold", 15.1F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.FolderLinkLbl.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.FolderLinkLbl.Location = new System.Drawing.Point(598, 121);
            this.FolderLinkLbl.Name = "FolderLinkLbl";
            this.FolderLinkLbl.Size = new System.Drawing.Size(306, 68);
            this.FolderLinkLbl.TabIndex = 5;
            this.FolderLinkLbl.Text = "Folder Links";
            // 
            // AddLinkBtn
            // 
            this.AddLinkBtn.BackColor = System.Drawing.Color.Transparent;
            this.AddLinkBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.AddLinkBtn.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.AddLinkBtn.Location = new System.Drawing.Point(609, 454);
            this.AddLinkBtn.Name = "AddLinkBtn";
            this.AddLinkBtn.Size = new System.Drawing.Size(407, 81);
            this.AddLinkBtn.TabIndex = 6;
            this.AddLinkBtn.Text = "Add Folder Link";
            this.AddLinkBtn.UseVisualStyleBackColor = true;
            this.AddLinkBtn.Click += new System.EventHandler(this.AddLinkBtn_Click);
            // 
            // EventLinkNameTxtBox
            // 
            this.EventLinkNameTxtBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.EventLinkNameTxtBox.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.EventLinkNameTxtBox.Location = new System.Drawing.Point(606, 268);
            this.EventLinkNameTxtBox.Name = "EventLinkNameTxtBox";
            this.EventLinkNameTxtBox.PlaceholderText = " Name";
            this.EventLinkNameTxtBox.Size = new System.Drawing.Size(217, 47);
            this.EventLinkNameTxtBox.TabIndex = 7;
            this.EventLinkNameTxtBox.TextChanged += new System.EventHandler(this.EventLinkNameTxtBox_TextChanged);
            // 
            // NoteNameLinkTxtBox
            // 
            this.NoteNameLinkTxtBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.NoteNameLinkTxtBox.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.NoteNameLinkTxtBox.Location = new System.Drawing.Point(609, 384);
            this.NoteNameLinkTxtBox.Name = "NoteNameLinkTxtBox";
            this.NoteNameLinkTxtBox.PlaceholderText = " Note Name";
            this.NoteNameLinkTxtBox.Size = new System.Drawing.Size(250, 47);
            this.NoteNameLinkTxtBox.TabIndex = 8;
            this.NoteNameLinkTxtBox.TextChanged += new System.EventHandler(this.NoteNameLinkTxtBox_TextChanged);
            // 
            // EventFolderLinkLbl
            // 
            this.EventFolderLinkLbl.AutoSize = true;
            this.EventFolderLinkLbl.Font = new System.Drawing.Font("Arimo", 9.900001F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.EventFolderLinkLbl.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.EventFolderLinkLbl.Location = new System.Drawing.Point(601, 209);
            this.EventFolderLinkLbl.Name = "EventFolderLinkLbl";
            this.EventFolderLinkLbl.Size = new System.Drawing.Size(442, 39);
            this.EventFolderLinkLbl.TabIndex = 9;
            this.EventFolderLinkLbl.Text = "Event Info : Name, Due Date";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arimo", 9.900001F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(601, 329);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(152, 39);
            this.label1.TabIndex = 10;
            this.label1.Text = "Note Info";
            // 
            // EventLinkDueDateTxtBox
            // 
            this.EventLinkDueDateTxtBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.EventLinkDueDateTxtBox.ForeColor = System.Drawing.SystemColors.InactiveBorder;
            this.EventLinkDueDateTxtBox.Location = new System.Drawing.Point(850, 268);
            this.EventLinkDueDateTxtBox.Name = "EventLinkDueDateTxtBox";
            this.EventLinkDueDateTxtBox.PlaceholderText = " YYYY/MM";
            this.EventLinkDueDateTxtBox.Size = new System.Drawing.Size(166, 47);
            this.EventLinkDueDateTxtBox.TabIndex = 11;
            this.EventLinkDueDateTxtBox.TextChanged += new System.EventHandler(this.EventDueDateTxtBox_TextChanged);
            // 
            // SelectedFolderLbl
            // 
            this.SelectedFolderLbl.AutoSize = true;
            this.SelectedFolderLbl.Font = new System.Drawing.Font("Segoe UI Semibold", 15.1F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.SelectedFolderLbl.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.SelectedFolderLbl.Location = new System.Drawing.Point(1140, 121);
            this.SelectedFolderLbl.Name = "SelectedFolderLbl";
            this.SelectedFolderLbl.Size = new System.Drawing.Size(550, 68);
            this.SelectedFolderLbl.TabIndex = 12;
            this.SelectedFolderLbl.Text = "Selected Folder Name ";
            // 
            // LinkNameLbl
            // 
            this.LinkNameLbl.AutoSize = true;
            this.LinkNameLbl.Font = new System.Drawing.Font("Arimo", 9.900001F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.LinkNameLbl.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.LinkNameLbl.Location = new System.Drawing.Point(1140, 209);
            this.LinkNameLbl.Name = "LinkNameLbl";
            this.LinkNameLbl.Size = new System.Drawing.Size(176, 39);
            this.LinkNameLbl.TabIndex = 13;
            this.LinkNameLbl.Text = "Link Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arimo", 9.900001F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(1911, 209);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(229, 39);
            this.label2.TabIndex = 14;
            this.label2.Text = "Link Due Date";
            // 
            // LinkContentTxtBox
            // 
            this.LinkContentTxtBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(35)))), ((int)(((byte)(38)))));
            this.LinkContentTxtBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.LinkContentTxtBox.ForeColor = System.Drawing.SystemColors.Control;
            this.LinkContentTxtBox.Location = new System.Drawing.Point(1140, 294);
            this.LinkContentTxtBox.Multiline = true;
            this.LinkContentTxtBox.Name = "LinkContentTxtBox";
            this.LinkContentTxtBox.Size = new System.Drawing.Size(1062, 857);
            this.LinkContentTxtBox.TabIndex = 15;
            // 
            // DueDateLbl
            // 
            this.DueDateLbl.AutoSize = true;
            this.DueDateLbl.Font = new System.Drawing.Font("Arimo", 9.900001F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.DueDateLbl.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.DueDateLbl.Location = new System.Drawing.Point(1140, 1186);
            this.DueDateLbl.Name = "DueDateLbl";
            this.DueDateLbl.Size = new System.Drawing.Size(176, 39);
            this.DueDateLbl.TabIndex = 16;
            this.DueDateLbl.Text = "Due Date: ";
            // 
            // DueDateAddLbl
            // 
            this.DueDateAddLbl.AutoSize = true;
            this.DueDateAddLbl.Font = new System.Drawing.Font("Arimo", 9.900001F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.DueDateAddLbl.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.DueDateAddLbl.Location = new System.Drawing.Point(1286, 1186);
            this.DueDateAddLbl.Name = "DueDateAddLbl";
            this.DueDateAddLbl.Size = new System.Drawing.Size(89, 39);
            this.DueDateAddLbl.TabIndex = 17;
            this.DueDateAddLbl.Text = "........";
            // 
            // MainFolderLbl
            // 
            this.MainFolderLbl.AutoSize = true;
            this.MainFolderLbl.Font = new System.Drawing.Font("Segoe UI Semibold", 15.1F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.MainFolderLbl.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.MainFolderLbl.Location = new System.Drawing.Point(72, 121);
            this.MainFolderLbl.Name = "MainFolderLbl";
            this.MainFolderLbl.Size = new System.Drawing.Size(197, 68);
            this.MainFolderLbl.TabIndex = 18;
            this.MainFolderLbl.Text = "Folders";
            // 
            // NoteLinkGallery
            // 
            this.NoteLinkGallery.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(35)))), ((int)(((byte)(38)))));
            this.NoteLinkGallery.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.Desktop;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.NoteLinkGallery.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.NoteLinkGallery.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.NoteLinkGallery.ColumnHeadersVisible = false;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.Color.CornflowerBlue;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.ControlLight;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.NoteLinkGallery.DefaultCellStyle = dataGridViewCellStyle5;
            this.NoteLinkGallery.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(55)))), ((int)(((byte)(71)))));
            this.NoteLinkGallery.Location = new System.Drawing.Point(601, 914);
            this.NoteLinkGallery.Name = "NoteLinkGallery";
            this.NoteLinkGallery.RowHeadersVisible = false;
            this.NoteLinkGallery.RowHeadersWidth = 102;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(55)))), ((int)(((byte)(71)))));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(78)))), ((int)(((byte)(94)))));
            this.NoteLinkGallery.RowsDefaultCellStyle = dataGridViewCellStyle6;
            this.NoteLinkGallery.RowTemplate.Height = 49;
            this.NoteLinkGallery.Size = new System.Drawing.Size(415, 311);
            this.NoteLinkGallery.TabIndex = 19;
            this.NoteLinkGallery.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.NoteLinkGallery_CellClick);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 49.1F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(37)))), ((int)(((byte)(80)))));
            this.label3.Location = new System.Drawing.Point(176, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(1087, 219);
            this.label3.TabIndex = 20;
            this.label3.Text = "F O L D E R S ";
            // 
            // FolderList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(17F, 41F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(25)))), ((int)(((byte)(21)))));
            this.ClientSize = new System.Drawing.Size(2287, 1252);
            this.Controls.Add(this.NoteLinkGallery);
            this.Controls.Add(this.MainFolderLbl);
            this.Controls.Add(this.DueDateAddLbl);
            this.Controls.Add(this.DueDateLbl);
            this.Controls.Add(this.LinkContentTxtBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.LinkNameLbl);
            this.Controls.Add(this.SelectedFolderLbl);
            this.Controls.Add(this.EventLinkDueDateTxtBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.EventFolderLinkLbl);
            this.Controls.Add(this.NoteNameLinkTxtBox);
            this.Controls.Add(this.EventLinkNameTxtBox);
            this.Controls.Add(this.AddLinkBtn);
            this.Controls.Add(this.FolderLinkLbl);
            this.Controls.Add(this.FolderNameTxtBox);
            this.Controls.Add(this.EventLinkGallery);
            this.Controls.Add(this.FolderGallery);
            this.Controls.Add(this.NewFolderBtn);
            this.Controls.Add(this.GolderLbl);
            this.Controls.Add(this.label3);
            this.ForeColor = System.Drawing.SystemColors.Control;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FolderList";
            this.Text = "FolderList";
            ((System.ComponentModel.ISupportInitialize)(this.FolderGallery)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EventLinkGallery)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.NoteLinkGallery)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label GolderLbl;
        private Button NewFolderBtn;
        private DataGridView FolderGallery;
        private DataGridView EventLinkGallery;
        private TextBox FolderNameTxtBox;
        private Label FolderLinkLbl;
        private Button AddLinkBtn;
        private TextBox EventLinkNameTxtBox;
        private TextBox NoteNameLinkTxtBox;
        private Label EventFolderLinkLbl;
        private Label label1;
        private TextBox EventLinkDueDateTxtBox;
        private Label SelectedFolderLbl;
        private Label LinkNameLbl;
        private Label label2;
        private TextBox LinkContentTxtBox;
        private Label DueDateLbl;
        private Label DueDateAddLbl;
        private Label MainFolderLbl;
        private DataGridView NoteLinkGallery;
        private Label label3;
    }
}