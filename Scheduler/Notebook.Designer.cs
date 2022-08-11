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
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.NoteBookGallery)).BeginInit();
            this.SuspendLayout();
            // 
            // NoteBookGallery
            // 
            this.NoteBookGallery.AllowUserToAddRows = false;
            this.NoteBookGallery.AllowUserToDeleteRows = false;
            this.NoteBookGallery.AllowUserToResizeColumns = false;
            this.NoteBookGallery.AllowUserToResizeRows = false;
            this.NoteBookGallery.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.NoteBookGallery.Location = new System.Drawing.Point(145, 316);
            this.NoteBookGallery.Name = "NoteBookGallery";
            this.NoteBookGallery.RowHeadersVisible = false;
            this.NoteBookGallery.RowHeadersWidth = 102;
            this.NoteBookGallery.RowTemplate.Height = 49;
            this.NoteBookGallery.Size = new System.Drawing.Size(411, 701);
            this.NoteBookGallery.TabIndex = 0;
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
            this.NoteTitleTxtBox.Location = new System.Drawing.Point(864, 228);
            this.NoteTitleTxtBox.Name = "NoteTitleTxtBox";
            this.NoteTitleTxtBox.Size = new System.Drawing.Size(710, 47);
            this.NoteTitleTxtBox.TabIndex = 2;
            // 
            // NoteMsgTxtBox
            // 
            this.NoteMsgTxtBox.Location = new System.Drawing.Point(864, 316);
            this.NoteMsgTxtBox.Multiline = true;
            this.NoteMsgTxtBox.Name = "NoteMsgTxtBox";
            this.NoteMsgTxtBox.Size = new System.Drawing.Size(1068, 701);
            this.NoteMsgTxtBox.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 15.1F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label2.Location = new System.Drawing.Point(145, 123);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(252, 68);
            this.label2.TabIndex = 4;
            this.label2.Text = "My Notes";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9.900001F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label3.Location = new System.Drawing.Point(735, 316);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(116, 46);
            this.label3.TabIndex = 5;
            this.label3.Text = "Notes:";
            // 
            // NewNoteBtn
            // 
            this.NewNoteBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(42)))));
            this.NewNoteBtn.Location = new System.Drawing.Point(145, 222);
            this.NewNoteBtn.Name = "NewNoteBtn";
            this.NewNoteBtn.Size = new System.Drawing.Size(407, 58);
            this.NewNoteBtn.TabIndex = 6;
            this.NewNoteBtn.Text = "New Notebook";
            this.NewNoteBtn.UseVisualStyleBackColor = true;
            this.NewNoteBtn.Click += new System.EventHandler(this.NewNoteBtn_Click);
            // 
            // SaveNoteBtn
            // 
            this.SaveNoteBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(42)))));
            this.SaveNoteBtn.Location = new System.Drawing.Point(864, 1054);
            this.SaveNoteBtn.Name = "SaveNoteBtn";
            this.SaveNoteBtn.Size = new System.Drawing.Size(188, 55);
            this.SaveNoteBtn.TabIndex = 7;
            this.SaveNoteBtn.Text = "Save";
            this.SaveNoteBtn.UseVisualStyleBackColor = true;
            this.SaveNoteBtn.Click += new System.EventHandler(this.SaveNoteBtn_Click);
            // 
            // ReadNoteBtn
            // 
            this.ReadNoteBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(42)))));
            this.ReadNoteBtn.Location = new System.Drawing.Point(145, 1054);
            this.ReadNoteBtn.Name = "ReadNoteBtn";
            this.ReadNoteBtn.Size = new System.Drawing.Size(188, 55);
            this.ReadNoteBtn.TabIndex = 8;
            this.ReadNoteBtn.Text = "Read";
            this.ReadNoteBtn.UseVisualStyleBackColor = true;
            this.ReadNoteBtn.Click += new System.EventHandler(this.ReadNoteBtn_Click);
            // 
            // DeleteNoteBtn
            // 
            this.DeleteNoteBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(42)))));
            this.DeleteNoteBtn.Location = new System.Drawing.Point(364, 1054);
            this.DeleteNoteBtn.Name = "DeleteNoteBtn";
            this.DeleteNoteBtn.Size = new System.Drawing.Size(188, 55);
            this.DeleteNoteBtn.TabIndex = 9;
            this.DeleteNoteBtn.Text = "Delete";
            this.DeleteNoteBtn.UseVisualStyleBackColor = true;
            this.DeleteNoteBtn.Click += new System.EventHandler(this.DeleteNoteBtn_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 15.1F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label4.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label4.Location = new System.Drawing.Point(666, 123);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(315, 68);
            this.label4.TabIndex = 10;
            this.label4.Text = "My Notes > ";
            // 
            // Notebook
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(17F, 41F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.ClientSize = new System.Drawing.Size(2291, 1442);
            this.Controls.Add(this.label4);
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
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
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
        private Label label4;
    }
}