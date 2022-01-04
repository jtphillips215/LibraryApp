
namespace phillips_james_semesterProject
{
    partial class FindMediaForm
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
            this.searchMediaText = new System.Windows.Forms.TextBox();
            this.mediaSearchButton = new System.Windows.Forms.Button();
            this.bookRadioButton = new System.Windows.Forms.RadioButton();
            this.movieRadioButton = new System.Windows.Forms.RadioButton();
            this.magRadioButton = new System.Windows.Forms.RadioButton();
            this.resultsBox = new System.Windows.Forms.ListBox();
            this.CancelButton = new System.Windows.Forms.Button();
            this.DeleteButton = new System.Windows.Forms.Button();
            this.DeletedLabel = new System.Windows.Forms.Label();
            this.CheckOutButton = new System.Windows.Forms.Button();
            this.CheckOutLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // searchMediaText
            // 
            this.searchMediaText.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.searchMediaText.Location = new System.Drawing.Point(185, 68);
            this.searchMediaText.Name = "searchMediaText";
            this.searchMediaText.Size = new System.Drawing.Size(372, 27);
            this.searchMediaText.TabIndex = 2;
            this.searchMediaText.Text = "Enter Information Here";
            // 
            // mediaSearchButton
            // 
            this.mediaSearchButton.Location = new System.Drawing.Point(463, 101);
            this.mediaSearchButton.Name = "mediaSearchButton";
            this.mediaSearchButton.Size = new System.Drawing.Size(94, 29);
            this.mediaSearchButton.TabIndex = 3;
            this.mediaSearchButton.Text = "Search";
            this.mediaSearchButton.UseVisualStyleBackColor = true;
            this.mediaSearchButton.Click += new System.EventHandler(this.mediaSearchButton_Click);
            // 
            // bookRadioButton
            // 
            this.bookRadioButton.AutoSize = true;
            this.bookRadioButton.Location = new System.Drawing.Point(185, 101);
            this.bookRadioButton.Name = "bookRadioButton";
            this.bookRadioButton.Size = new System.Drawing.Size(118, 24);
            this.bookRadioButton.TabIndex = 4;
            this.bookRadioButton.TabStop = true;
            this.bookRadioButton.Text = "Search Books";
            this.bookRadioButton.UseVisualStyleBackColor = true;
            // 
            // movieRadioButton
            // 
            this.movieRadioButton.AutoSize = true;
            this.movieRadioButton.Location = new System.Drawing.Point(185, 131);
            this.movieRadioButton.Name = "movieRadioButton";
            this.movieRadioButton.Size = new System.Drawing.Size(125, 24);
            this.movieRadioButton.TabIndex = 5;
            this.movieRadioButton.TabStop = true;
            this.movieRadioButton.Text = "Search Movies";
            this.movieRadioButton.UseVisualStyleBackColor = true;
            // 
            // magRadioButton
            // 
            this.magRadioButton.AutoSize = true;
            this.magRadioButton.Location = new System.Drawing.Point(185, 161);
            this.magRadioButton.Name = "magRadioButton";
            this.magRadioButton.Size = new System.Drawing.Size(149, 24);
            this.magRadioButton.TabIndex = 6;
            this.magRadioButton.TabStop = true;
            this.magRadioButton.Text = "Search Magazines";
            this.magRadioButton.UseVisualStyleBackColor = true;
            // 
            // resultsBox
            // 
            this.resultsBox.FormattingEnabled = true;
            this.resultsBox.ItemHeight = 20;
            this.resultsBox.Location = new System.Drawing.Point(185, 191);
            this.resultsBox.Name = "resultsBox";
            this.resultsBox.Size = new System.Drawing.Size(372, 124);
            this.resultsBox.TabIndex = 7;
            // 
            // CancelButton
            // 
            this.CancelButton.Location = new System.Drawing.Point(463, 321);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(94, 29);
            this.CancelButton.TabIndex = 8;
            this.CancelButton.Text = "Cancel";
            this.CancelButton.UseVisualStyleBackColor = true;
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // DeleteButton
            // 
            this.DeleteButton.Location = new System.Drawing.Point(326, 321);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(94, 29);
            this.DeleteButton.TabIndex = 9;
            this.DeleteButton.Text = "Delete";
            this.DeleteButton.UseVisualStyleBackColor = true;
            this.DeleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // DeletedLabel
            // 
            this.DeletedLabel.AutoSize = true;
            this.DeletedLabel.Location = new System.Drawing.Point(306, 370);
            this.DeletedLabel.Name = "DeletedLabel";
            this.DeletedLabel.Size = new System.Drawing.Size(126, 20);
            this.DeletedLabel.TabIndex = 10;
            this.DeletedLabel.Text = "Member Deleted!";
            this.DeletedLabel.Visible = false;
            // 
            // CheckOutButton
            // 
            this.CheckOutButton.Location = new System.Drawing.Point(185, 321);
            this.CheckOutButton.Name = "CheckOutButton";
            this.CheckOutButton.Size = new System.Drawing.Size(94, 29);
            this.CheckOutButton.TabIndex = 11;
            this.CheckOutButton.Text = "Check Out";
            this.CheckOutButton.UseVisualStyleBackColor = true;
            this.CheckOutButton.Click += new System.EventHandler(this.CheckOutButton_Click);
            // 
            // CheckOutLabel
            // 
            this.CheckOutLabel.AutoSize = true;
            this.CheckOutLabel.Location = new System.Drawing.Point(306, 370);
            this.CheckOutLabel.Name = "CheckOutLabel";
            this.CheckOutLabel.Size = new System.Drawing.Size(141, 20);
            this.CheckOutLabel.TabIndex = 12;
            this.CheckOutLabel.Text = "Media Checked out!";
            this.CheckOutLabel.Visible = false;
            // 
            // FindMediaForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(782, 453);
            this.Controls.Add(this.CheckOutLabel);
            this.Controls.Add(this.CheckOutButton);
            this.Controls.Add(this.DeletedLabel);
            this.Controls.Add(this.DeleteButton);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.resultsBox);
            this.Controls.Add(this.magRadioButton);
            this.Controls.Add(this.movieRadioButton);
            this.Controls.Add(this.bookRadioButton);
            this.Controls.Add(this.mediaSearchButton);
            this.Controls.Add(this.searchMediaText);
            this.Name = "FindMediaForm";
            this.Text = "Find Media";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox searchMediaText;
        private System.Windows.Forms.Button mediaSearchButton;
        private System.Windows.Forms.RadioButton bookRadioButton;
        private System.Windows.Forms.RadioButton movieRadioButton;
        private System.Windows.Forms.RadioButton magRadioButton;
        private System.Windows.Forms.ListBox resultsBox;
        private System.Windows.Forms.Button CancelButton;
        private System.Windows.Forms.Button DeleteButton;
        private System.Windows.Forms.Label DeletedLabel;
        private System.Windows.Forms.Button CheckOutButton;
        private System.Windows.Forms.Label CheckOutLabel;
    }
}