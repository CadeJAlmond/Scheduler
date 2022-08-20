namespace Scheduler
{
    partial class Notebook
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
            this.NoteBookGallery = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.NoteTitleTxtBox = new System.Windows.Forms.TextBox();
            this.NoteMsgTxtBox = new System.Windows.Forms.TextBox();
            this.MyNotesListLbl = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.NewNoteBtn = new System.Windows.Forms.Button();
            this.SaveNoteBtn = new System.Windows.Forms.Button();
            this.DeleteNoteBtn = new System.Windows.Forms.Button();
            this.MyNotesDisplayLbl = new System.Windows.Forms.Label();
            this.NoteTitleLbl = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.NoteBookGallery)).BeginInit();
            this.SuspendLayout();
            // 
            // NoteBookGallery
            // 
            this.NoteBookGallery.AllowUserToAddRows = false;
            this.NoteBookGallery.AllowUserToDeleteRows = false;
            this.NoteBookGallery.AllowUserToResizeColumns = false;
            this.NoteBookGallery.AllowUserToResizeRows = false;
            this.NoteBookGallery.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.NoteBookGallery.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.NoteBookGallery.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(23)))), ((int)(((byte)(23)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.CornflowerBlue;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.NoteBookGallery.DefaultCellStyle = dataGridViewCellStyle1;
            this.NoteBookGallery.GridColor = System.Drawing.SystemColors.Control;
            this.NoteBookGallery.Location = new System.Drawing.Point(145, 358);
            this.NoteBookGallery.Name = "NoteBookGallery";
            this.NoteBookGallery.RowHeadersVisible = false;
            this.NoteBookGallery.RowHeadersWidth = 102;
            this.NoteBookGallery.RowTemplate.Height = 49;
            this.NoteBookGallery.Size = new System.Drawing.Size(411, 768);
            this.NoteBookGallery.TabIndex = 0;
            this.NoteBookGallery.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.NoteBookGallery_CellClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9.900001F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label1.Location = new System.Drawing.Point(758, 228);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 46);
            this.label1.TabIndex = 1;
            this.label1.Text = "Title:";
            // 
            // NoteTitleTxtBox
            // 
            this.NoteTitleTxtBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.NoteTitleTxtBox.Font = new System.Drawing.Font("Segoe UI", 11.1F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.NoteTitleTxtBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(239)))), ((int)(((byte)(239)))));
            this.NoteTitleTxtBox.Location = new System.Drawing.Point(864, 228);
            this.NoteTitleTxtBox.Multiline = true;
            this.NoteTitleTxtBox.Name = "NoteTitleTxtBox";
            this.NoteTitleTxtBox.Size = new System.Drawing.Size(710, 84);
            this.NoteTitleTxtBox.TabIndex = 2;
            this.NoteTitleTxtBox.TextChanged += new System.EventHandler(this.NoteTitleTxtBox_TextChanged);
            // 
            // NoteMsgTxtBox
            // 
            this.NoteMsgTxtBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.NoteMsgTxtBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(239)))), ((int)(((byte)(239)))));
            this.NoteMsgTxtBox.Location = new System.Drawing.Point(864, 358);
            this.NoteMsgTxtBox.Multiline = true;
            this.NoteMsgTxtBox.Name = "NoteMsgTxtBox";
            this.NoteMsgTxtBox.Size = new System.Drawing.Size(1068, 768);
            this.NoteMsgTxtBox.TabIndex = 3;
            // 
            // MyNotesListLbl
            // 
            this.MyNotesListLbl.AutoSize = true;
            this.MyNotesListLbl.Font = new System.Drawing.Font("Segoe UI Semibold", 15.1F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.MyNotesListLbl.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.MyNotesListLbl.Location = new System.Drawing.Point(145, 123);
            this.MyNotesListLbl.Name = "MyNotesListLbl";
            this.MyNotesListLbl.Size = new System.Drawing.Size(252, 68);
            this.MyNotesListLbl.TabIndex = 4;
            this.MyNotesListLbl.Text = "My Notes";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9.900001F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label3.Location = new System.Drawing.Point(735, 358);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(116, 46);
            this.label3.TabIndex = 5;
            this.label3.Text = "Notes:";
            // 
            // NewNoteBtn
            // 
            this.NewNoteBtn.BackColor = System.Drawing.Color.Transparent;
            this.NewNoteBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.NewNoteBtn.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.NewNoteBtn.Location = new System.Drawing.Point(145, 228);
            this.NewNoteBtn.Name = "NewNoteBtn";
            this.NewNoteBtn.Size = new System.Drawing.Size(407, 84);
            this.NewNoteBtn.TabIndex = 6;
            this.NewNoteBtn.Text = "New Notebook";
            this.NewNoteBtn.UseVisualStyleBackColor = false;
            this.NewNoteBtn.Click += new System.EventHandler(this.NewNoteBtn_Click);
            // 
            // SaveNoteBtn
            // 
            this.SaveNoteBtn.BackColor = System.Drawing.Color.Transparent;
            this.SaveNoteBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SaveNoteBtn.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.SaveNoteBtn.Location = new System.Drawing.Point(864, 1170);
            this.SaveNoteBtn.Name = "SaveNoteBtn";
            this.SaveNoteBtn.Size = new System.Drawing.Size(188, 55);
            this.SaveNoteBtn.TabIndex = 7;
            this.SaveNoteBtn.Text = "Save";
            this.SaveNoteBtn.UseVisualStyleBackColor = false;
            this.SaveNoteBtn.Click += new System.EventHandler(this.SaveNoteBtn_Click);
            // 
            // DeleteNoteBtn
            // 
            this.DeleteNoteBtn.BackColor = System.Drawing.Color.Transparent;
            this.DeleteNoteBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.DeleteNoteBtn.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.DeleteNoteBtn.Location = new System.Drawing.Point(1079, 1170);
            this.DeleteNoteBtn.Name = "DeleteNoteBtn";
            this.DeleteNoteBtn.Size = new System.Drawing.Size(188, 55);
            this.DeleteNoteBtn.TabIndex = 9;
            this.DeleteNoteBtn.Text = "Delete";
            this.DeleteNoteBtn.UseVisualStyleBackColor = false;
            this.DeleteNoteBtn.Click += new System.EventHandler(this.DeleteNoteBtn_Click);
            // 
            // MyNotesDisplayLbl
            // 
            this.MyNotesDisplayLbl.AutoSize = true;
            this.MyNotesDisplayLbl.Font = new System.Drawing.Font("Segoe UI Semibold", 15.1F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.MyNotesDisplayLbl.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.MyNotesDisplayLbl.Location = new System.Drawing.Point(853, 123);
            this.MyNotesDisplayLbl.Name = "MyNotesDisplayLbl";
            this.MyNotesDisplayLbl.Size = new System.Drawing.Size(315, 68);
            this.MyNotesDisplayLbl.TabIndex = 10;
            this.MyNotesDisplayLbl.Text = "My Notes > ";
            // 
            // NoteTitleLbl
            // 
            this.NoteTitleLbl.AutoSize = true;
            this.NoteTitleLbl.Font = new System.Drawing.Font("Segoe UI Semibold", 15.1F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.NoteTitleLbl.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.NoteTitleLbl.Location = new System.Drawing.Point(1135, 123);
            this.NoteTitleLbl.Name = "NoteTitleLbl";
            this.NoteTitleLbl.Size = new System.Drawing.Size(0, 68);
            this.NoteTitleLbl.TabIndex = 11;
            // 
            // Notebook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(17F, 41F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(23)))), ((int)(((byte)(23)))));
            this.ClientSize = new System.Drawing.Size(2291, 1442);
            this.Controls.Add(this.NoteTitleLbl);
            this.Controls.Add(this.MyNotesDisplayLbl);
            this.Controls.Add(this.DeleteNoteBtn);
            this.Controls.Add(this.SaveNoteBtn);
            this.Controls.Add(this.NewNoteBtn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.MyNotesListLbl);
            this.Controls.Add(this.NoteMsgTxtBox);
            this.Controls.Add(this.NoteTitleTxtBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.NoteBookGallery);
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(23)))), ((int)(((byte)(23)))), ((int)(((byte)(23)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Notebook";
            this.Text = "Notebook";
            this.Load += new System.EventHandler(this.Notebook_Load);
            ((System.ComponentModel.ISupportInitialize)(this.NoteBookGallery)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView NoteBookGallery;
        private Label label1;
        private TextBox NoteTitleTxtBox;
        private TextBox NoteMsgTxtBox;
        private Label MyNotesListLbl;
        private Label label3;
        private Button NewNoteBtn;
        private Button SaveNoteBtn;
        private Button DeleteNoteBtn;
        private Label MyNotesDisplayLbl;
        private Label NoteTitleLbl;
    }
}