
using System;

namespace phillips_james_semesterProject
{
    partial class AddMediaForm
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
            this.TitleTextBox = new System.Windows.Forms.TextBox();
            this.SectionComboBox = new System.Windows.Forms.ComboBox();
            this.BookGroupBox = new System.Windows.Forms.GroupBox();
            this.PageCountTextBox = new System.Windows.Forms.TextBox();
            this.SerialTextBox = new System.Windows.Forms.TextBox();
            this.AuthorTextBox = new System.Windows.Forms.TextBox();
            this.BookRadioButton = new System.Windows.Forms.RadioButton();
            this.MovieGroupBox = new System.Windows.Forms.GroupBox();
            this.LengthTextBox = new System.Windows.Forms.TextBox();
            this.MovieRadioButton = new System.Windows.Forms.RadioButton();
            this.MagGroupBox = new System.Windows.Forms.GroupBox();
            this.VolumeTextBox = new System.Windows.Forms.TextBox();
            this.MagRadioButton = new System.Windows.Forms.RadioButton();
            this.CancelButton = new System.Windows.Forms.Button();
            this.AddButton = new System.Windows.Forms.Button();
            this.AddMediaSuccess = new System.Windows.Forms.Label();
            this.MediaAddFailed = new System.Windows.Forms.Label();
            this.BookGroupBox.SuspendLayout();
            this.MovieGroupBox.SuspendLayout();
            this.MagGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // TitleTextBox
            // 
            this.TitleTextBox.Location = new System.Drawing.Point(138, 57);
            this.TitleTextBox.Name = "TitleTextBox";
            this.TitleTextBox.Size = new System.Drawing.Size(125, 27);
            this.TitleTextBox.TabIndex = 0;
            this.TitleTextBox.Text = "Title";
            // 
            // SectionComboBox
            // 
            this.SectionComboBox.FormattingEnabled = true;
            this.SectionComboBox.Items.AddRange(new object[] {
            "Archive",
            "Fiction",
            "Non-Fiction",
            "Reference",
            "Periodical",
            "Other",
            "Video"});
            this.SectionComboBox.Location = new System.Drawing.Point(402, 57);
            this.SectionComboBox.Name = "SectionComboBox";
            this.SectionComboBox.Size = new System.Drawing.Size(151, 28);
            this.SectionComboBox.TabIndex = 1;
            this.SectionComboBox.Text = "Section";
            // 
            // BookGroupBox
            // 
            this.BookGroupBox.Controls.Add(this.PageCountTextBox);
            this.BookGroupBox.Controls.Add(this.SerialTextBox);
            this.BookGroupBox.Controls.Add(this.AuthorTextBox);
            this.BookGroupBox.Location = new System.Drawing.Point(33, 144);
            this.BookGroupBox.Name = "BookGroupBox";
            this.BookGroupBox.Size = new System.Drawing.Size(199, 200);
            this.BookGroupBox.TabIndex = 2;
            this.BookGroupBox.TabStop = false;
            // 
            // PageCountTextBox
            // 
            this.PageCountTextBox.Enabled = false;
            this.PageCountTextBox.Location = new System.Drawing.Point(33, 167);
            this.PageCountTextBox.Name = "PageCountTextBox";
            this.PageCountTextBox.Size = new System.Drawing.Size(125, 27);
            this.PageCountTextBox.TabIndex = 11;
            this.PageCountTextBox.Text = "Page Count";
            // 
            // SerialTextBox
            // 
            this.SerialTextBox.Enabled = false;
            this.SerialTextBox.Location = new System.Drawing.Point(33, 104);
            this.SerialTextBox.Name = "SerialTextBox";
            this.SerialTextBox.Size = new System.Drawing.Size(125, 27);
            this.SerialTextBox.TabIndex = 10;
            this.SerialTextBox.Text = "ISBN";
            // 
            // AuthorTextBox
            // 
            this.AuthorTextBox.Enabled = false;
            this.AuthorTextBox.Location = new System.Drawing.Point(33, 43);
            this.AuthorTextBox.Name = "AuthorTextBox";
            this.AuthorTextBox.Size = new System.Drawing.Size(125, 27);
            this.AuthorTextBox.TabIndex = 9;
            this.AuthorTextBox.Text = "Author";
            // 
            // BookRadioButton
            // 
            this.BookRadioButton.AutoSize = true;
            this.BookRadioButton.Location = new System.Drawing.Point(81, 114);
            this.BookRadioButton.Name = "BookRadioButton";
            this.BookRadioButton.Size = new System.Drawing.Size(96, 24);
            this.BookRadioButton.TabIndex = 5;
            this.BookRadioButton.TabStop = true;
            this.BookRadioButton.Text = "Add Book";
            this.BookRadioButton.UseVisualStyleBackColor = true;
            this.BookRadioButton.CheckedChanged += new System.EventHandler(this.BookRadioButton_CheckedChanged);
            // 
            // MovieGroupBox
            // 
            this.MovieGroupBox.Controls.Add(this.LengthTextBox);
            this.MovieGroupBox.Location = new System.Drawing.Point(290, 144);
            this.MovieGroupBox.Name = "MovieGroupBox";
            this.MovieGroupBox.Size = new System.Drawing.Size(199, 200);
            this.MovieGroupBox.TabIndex = 3;
            this.MovieGroupBox.TabStop = false;
            // 
            // LengthTextBox
            // 
            this.LengthTextBox.Enabled = false;
            this.LengthTextBox.Location = new System.Drawing.Point(32, 43);
            this.LengthTextBox.Name = "LengthTextBox";
            this.LengthTextBox.Size = new System.Drawing.Size(125, 27);
            this.LengthTextBox.TabIndex = 9;
            this.LengthTextBox.Text = "Length";
            // 
            // MovieRadioButton
            // 
            this.MovieRadioButton.AutoSize = true;
            this.MovieRadioButton.Location = new System.Drawing.Point(333, 114);
            this.MovieRadioButton.Name = "MovieRadioButton";
            this.MovieRadioButton.Size = new System.Drawing.Size(103, 24);
            this.MovieRadioButton.TabIndex = 6;
            this.MovieRadioButton.TabStop = true;
            this.MovieRadioButton.Text = "Add Movie";
            this.MovieRadioButton.UseVisualStyleBackColor = true;
            this.MovieRadioButton.CheckedChanged += new System.EventHandler(this.MovieRadioButton_CheckedChanged);
            // 
            // MagGroupBox
            // 
            this.MagGroupBox.Controls.Add(this.VolumeTextBox);
            this.MagGroupBox.Location = new System.Drawing.Point(534, 144);
            this.MagGroupBox.Name = "MagGroupBox";
            this.MagGroupBox.Size = new System.Drawing.Size(199, 200);
            this.MagGroupBox.TabIndex = 4;
            this.MagGroupBox.TabStop = false;
            // 
            // VolumeTextBox
            // 
            this.VolumeTextBox.Enabled = false;
            this.VolumeTextBox.Location = new System.Drawing.Point(41, 43);
            this.VolumeTextBox.Name = "VolumeTextBox";
            this.VolumeTextBox.Size = new System.Drawing.Size(125, 27);
            this.VolumeTextBox.TabIndex = 9;
            this.VolumeTextBox.Text = "Volume Number";
            // 
            // MagRadioButton
            // 
            this.MagRadioButton.AutoSize = true;
            this.MagRadioButton.Location = new System.Drawing.Point(575, 114);
            this.MagRadioButton.Name = "MagRadioButton";
            this.MagRadioButton.Size = new System.Drawing.Size(127, 24);
            this.MagRadioButton.TabIndex = 7;
            this.MagRadioButton.TabStop = true;
            this.MagRadioButton.Text = "Add Magazine";
            this.MagRadioButton.UseVisualStyleBackColor = true;
            this.MagRadioButton.CheckedChanged += new System.EventHandler(this.MagRadioButton_CheckedChanged);
            // 
            // CancelButton
            // 
            this.CancelButton.Location = new System.Drawing.Point(534, 360);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(94, 29);
            this.CancelButton.TabIndex = 8;
            this.CancelButton.Text = "Cancel";
            this.CancelButton.UseVisualStyleBackColor = true;
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // AddButton
            // 
            this.AddButton.Location = new System.Drawing.Point(138, 360);
            this.AddButton.Name = "AddButton";
            this.AddButton.Size = new System.Drawing.Size(94, 29);
            this.AddButton.TabIndex = 9;
            this.AddButton.Text = "Add";
            this.AddButton.UseVisualStyleBackColor = true;
            this.AddButton.Click += new System.EventHandler(this.AddButton_Click);
            // 
            // AddMediaSuccess
            // 
            this.AddMediaSuccess.AutoSize = true;
            this.AddMediaSuccess.Location = new System.Drawing.Point(290, 360);
            this.AddMediaSuccess.Name = "AddMediaSuccess";
            this.AddMediaSuccess.Size = new System.Drawing.Size(102, 20);
            this.AddMediaSuccess.TabIndex = 10;
            this.AddMediaSuccess.Text = "Media added!";
            this.AddMediaSuccess.Visible = false;
            // 
            // MediaAddFailed
            // 
            this.MediaAddFailed.AutoSize = true;
            this.MediaAddFailed.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.MediaAddFailed.ForeColor = System.Drawing.Color.Red;
            this.MediaAddFailed.Location = new System.Drawing.Point(290, 360);
            this.MediaAddFailed.Name = "MediaAddFailed";
            this.MediaAddFailed.Size = new System.Drawing.Size(194, 20);
            this.MediaAddFailed.TabIndex = 11;
            this.MediaAddFailed.Text = "Error! Failed to add media.";
            this.MediaAddFailed.Visible = false;
            // 
            // AddMediaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(782, 453);
            this.Controls.Add(this.MediaAddFailed);
            this.Controls.Add(this.AddMediaSuccess);
            this.Controls.Add(this.AddButton);
            this.Controls.Add(this.MagRadioButton);
            this.Controls.Add(this.MovieRadioButton);
            this.Controls.Add(this.BookRadioButton);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.MagGroupBox);
            this.Controls.Add(this.MovieGroupBox);
            this.Controls.Add(this.BookGroupBox);
            this.Controls.Add(this.SectionComboBox);
            this.Controls.Add(this.TitleTextBox);
            this.Name = "AddMediaForm";
            this.Text = "Add Media";
            this.BookGroupBox.ResumeLayout(false);
            this.BookGroupBox.PerformLayout();
            this.MovieGroupBox.ResumeLayout(false);
            this.MovieGroupBox.PerformLayout();
            this.MagGroupBox.ResumeLayout(false);
            this.MagGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TitleTextBox;
        private System.Windows.Forms.ComboBox SectionComboBox;
        private System.Windows.Forms.GroupBox BookGroupBox;
        private System.Windows.Forms.GroupBox MovieGroupBox;
        private System.Windows.Forms.GroupBox MagGroupBox;
        private System.Windows.Forms.RadioButton BookRadioButton;
        private System.Windows.Forms.RadioButton MovieRadioButton;
        private System.Windows.Forms.RadioButton MagRadioButton;
        private System.Windows.Forms.Button CancelButton;
        private System.Windows.Forms.TextBox PageCountTextBox;
        private System.Windows.Forms.TextBox SerialTextBox;
        private System.Windows.Forms.TextBox AuthorTextBox;
        private System.Windows.Forms.TextBox LengthTextBox;
        private System.Windows.Forms.TextBox VolumeTextBox;
        private System.Windows.Forms.Button AddButton;
        private System.Windows.Forms.Label AddMediaSuccess;
        private System.Windows.Forms.Label MediaAddFailed;

        public EventHandler AddMediaForm_Load { get; private set; }
    }
}