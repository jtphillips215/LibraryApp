
namespace phillips_james_semesterProject
{
    partial class FindMemberForm
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
            this.searchMemberText = new System.Windows.Forms.TextBox();
            this.nameRadioButton = new System.Windows.Forms.RadioButton();
            this.memberidRadioButton = new System.Windows.Forms.RadioButton();
            this.memberSearchButton = new System.Windows.Forms.Button();
            this.membersResults = new System.Windows.Forms.ListBox();
            this.deleteMemberButton = new System.Windows.Forms.Button();
            this.CancelButton = new System.Windows.Forms.Button();
            this.DeletedLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // searchMemberText
            // 
            this.searchMemberText.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.searchMemberText.Location = new System.Drawing.Point(188, 69);
            this.searchMemberText.Name = "searchMemberText";
            this.searchMemberText.Size = new System.Drawing.Size(372, 27);
            this.searchMemberText.TabIndex = 3;
            this.searchMemberText.Text = "Enter Information Here";
            // 
            // nameRadioButton
            // 
            this.nameRadioButton.AutoSize = true;
            this.nameRadioButton.Location = new System.Drawing.Point(188, 102);
            this.nameRadioButton.Name = "nameRadioButton";
            this.nameRadioButton.Size = new System.Drawing.Size(124, 24);
            this.nameRadioButton.TabIndex = 4;
            this.nameRadioButton.TabStop = true;
            this.nameRadioButton.Text = "Search Names";
            this.nameRadioButton.UseVisualStyleBackColor = true;
            // 
            // memberidRadioButton
            // 
            this.memberidRadioButton.AutoSize = true;
            this.memberidRadioButton.Location = new System.Drawing.Point(188, 132);
            this.memberidRadioButton.Name = "memberidRadioButton";
            this.memberidRadioButton.Size = new System.Drawing.Size(159, 24);
            this.memberidRadioButton.TabIndex = 5;
            this.memberidRadioButton.TabStop = true;
            this.memberidRadioButton.Text = "Search Member IDs";
            this.memberidRadioButton.UseVisualStyleBackColor = true;
            // 
            // memberSearchButton
            // 
            this.memberSearchButton.Location = new System.Drawing.Point(466, 102);
            this.memberSearchButton.Name = "memberSearchButton";
            this.memberSearchButton.Size = new System.Drawing.Size(94, 54);
            this.memberSearchButton.TabIndex = 6;
            this.memberSearchButton.Text = "Search";
            this.memberSearchButton.UseVisualStyleBackColor = true;
            // 
            // membersResults
            // 
            this.membersResults.FormattingEnabled = true;
            this.membersResults.ItemHeight = 20;
            this.membersResults.Location = new System.Drawing.Point(188, 184);
            this.membersResults.Name = "membersResults";
            this.membersResults.Size = new System.Drawing.Size(372, 124);
            this.membersResults.TabIndex = 7;
            // 
            // deleteMemberButton
            // 
            this.deleteMemberButton.Location = new System.Drawing.Point(188, 326);
            this.deleteMemberButton.Name = "deleteMemberButton";
            this.deleteMemberButton.Size = new System.Drawing.Size(94, 29);
            this.deleteMemberButton.TabIndex = 8;
            this.deleteMemberButton.Text = "Delete";
            this.deleteMemberButton.UseVisualStyleBackColor = true;
            this.deleteMemberButton.Click += new System.EventHandler(this.deleteMemberButton_Click);
            // 
            // CancelButton
            // 
            this.CancelButton.Location = new System.Drawing.Point(466, 326);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(94, 29);
            this.CancelButton.TabIndex = 9;
            this.CancelButton.Text = "Cancel";
            this.CancelButton.UseVisualStyleBackColor = true;
            this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
            // 
            // DeletedLabel
            // 
            this.DeletedLabel.AutoSize = true;
            this.DeletedLabel.Location = new System.Drawing.Point(310, 330);
            this.DeletedLabel.Name = "DeletedLabel";
            this.DeletedLabel.Size = new System.Drawing.Size(126, 20);
            this.DeletedLabel.TabIndex = 10;
            this.DeletedLabel.Text = "Member Deleted!";
            this.DeletedLabel.Visible = false;
            // 
            // FindMemberForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(782, 453);
            this.Controls.Add(this.DeletedLabel);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.deleteMemberButton);
            this.Controls.Add(this.membersResults);
            this.Controls.Add(this.memberSearchButton);
            this.Controls.Add(this.memberidRadioButton);
            this.Controls.Add(this.nameRadioButton);
            this.Controls.Add(this.searchMemberText);
            this.Name = "FindMemberForm";
            this.Text = "Find Member";
            this.Load += new System.EventHandler(this.FindMemberForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox searchMemberText;
        private System.Windows.Forms.RadioButton nameRadioButton;
        private System.Windows.Forms.RadioButton memberidRadioButton;
        private System.Windows.Forms.Button memberSearchButton;
        public System.Windows.Forms.ListBox membersResults;
        private System.Windows.Forms.Button deleteMemberButton;
        private System.Windows.Forms.Button CancelButton;
        private System.Windows.Forms.Label DeletedLabel;
    }
}