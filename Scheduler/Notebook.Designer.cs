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
            this.NoteBookGallery = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.NoteTitleTxtBox = new System.Windows.Forms.TextBox();
            this.NoteMsgTxtBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.NewNoteBtn = new System.Windows.Forms.Button();
            this.SaveNoteBtn = new System.Windows.Forms.Button();
            this.ReadNoteBtn = new System.Windows.Forms.Button();
            this.DeleteNoteBtn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.NoteBookGallery)).BeginInit();
            this.SuspendLayout();
            // 
            // NoteBookGallery
            // 
            this.NoteBookGallery.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.NoteBookGallery.Location = new System.Drawing.Point(1031, 223);
            this.NoteBookGallery.Name = "NoteBookGallery";
            this.NoteBookGallery.RowHeadersWidth = 102;
            this.NoteBookGallery.RowTemplate.Height = 49;
            this.NoteBookGallery.Size = new System.Drawing.Size(483, 587);
            this.NoteBookGallery.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(112, 212);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 41);
            this.label1.TabIndex = 1;
            this.label1.Text = "Title:";
            // 
            // NoteTitleTxtBox
            // 
            this.NoteTitleTxtBox.Location = new System.Drawing.Point(218, 212);
            this.NoteTitleTxtBox.Name = "NoteTitleTxtBox";
            this.NoteTitleTxtBox.Size = new System.Drawing.Size(355, 47);
            this.NoteTitleTxtBox.TabIndex = 2;
            // 
            // NoteMsgTxtBox
            // 
            this.NoteMsgTxtBox.Location = new System.Drawing.Point(218, 300);
            this.NoteMsgTxtBox.Multiline = true;
            this.NoteMsgTxtBox.Name = "NoteMsgTxtBox";
            this.NoteMsgTxtBox.Size = new System.Drawing.Size(675, 510);
            this.NoteMsgTxtBox.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(1031, 168);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(173, 41);
            this.label2.TabIndex = 4;
            this.label2.Text = "Notebooks:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(89, 300);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 41);
            this.label3.TabIndex = 5;
            this.label3.Text = "Notes:";
            // 
            // NewNoteBtn
            // 
            this.NewNoteBtn.Location = new System.Drawing.Point(611, 206);
            this.NewNoteBtn.Name = "NewNoteBtn";
            this.NewNoteBtn.Size = new System.Drawing.Size(268, 58);
            this.NewNoteBtn.TabIndex = 6;
            this.NewNoteBtn.Text = "New Notebook";
            this.NewNoteBtn.UseVisualStyleBackColor = true;
            this.NewNoteBtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // SaveNoteBtn
            // 
            this.SaveNoteBtn.Location = new System.Drawing.Point(218, 844);
            this.SaveNoteBtn.Name = "SaveNoteBtn";
            this.SaveNoteBtn.Size = new System.Drawing.Size(188, 58);
            this.SaveNoteBtn.TabIndex = 7;
            this.SaveNoteBtn.Text = "Save";
            this.SaveNoteBtn.UseVisualStyleBackColor = true;
            this.SaveNoteBtn.Click += new System.EventHandler(this.SaveNoteBtn_Click);
            // 
            // ReadNoteBtn
            // 
            this.ReadNoteBtn.Location = new System.Drawing.Point(1031, 844);
            this.ReadNoteBtn.Name = "ReadNoteBtn";
            this.ReadNoteBtn.Size = new System.Drawing.Size(188, 58);
            this.ReadNoteBtn.TabIndex = 8;
            this.ReadNoteBtn.Text = "Read";
            this.ReadNoteBtn.UseVisualStyleBackColor = true;
            this.ReadNoteBtn.Click += new System.EventHandler(this.ReadNoteBtn_Click);
            // 
            // DeleteNoteBtn
            // 
            this.DeleteNoteBtn.Location = new System.Drawing.Point(1250, 844);
            this.DeleteNoteBtn.Name = "DeleteNoteBtn";
            this.DeleteNoteBtn.Size = new System.Drawing.Size(188, 58);
            this.DeleteNoteBtn.TabIndex = 9;
            this.DeleteNoteBtn.Text = "Delete";
            this.DeleteNoteBtn.UseVisualStyleBackColor = true;
            this.DeleteNoteBtn.Click += new System.EventHandler(this.DeleteNoteBtn_Click);
            // 
            // Notebook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(17F, 41F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1710, 1117);
            this.Controls.Add(this.DeleteNoteBtn);
            this.Controls.Add(this.ReadNoteBtn);
            this.Controls.Add(this.SaveNoteBtn);
            this.Controls.Add(this.NewNoteBtn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.NoteMsgTxtBox);
            this.Controls.Add(this.NoteTitleTxtBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.NoteBookGallery);
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
        private Label label2;
        private Label label3;
        private Button NewNoteBtn;
        private Button SaveNoteBtn;
        private Button ReadNoteBtn;
        private Button DeleteNoteBtn;
    }
}