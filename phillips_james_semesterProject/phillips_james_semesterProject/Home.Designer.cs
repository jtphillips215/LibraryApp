
namespace phillips_james_semesterProject
{
    partial class Home
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.findMedia = new System.Windows.Forms.Button();
            this.addMedia = new System.Windows.Forms.Button();
            this.findMember = new System.Windows.Forms.Button();
            this.addMember = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(132, 50);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.label1.Size = new System.Drawing.Size(535, 81);
            this.label1.TabIndex = 6;
            this.label1.Text = "Harborview Library";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // findMedia
            // 
            this.findMedia.Location = new System.Drawing.Point(80, 181);
            this.findMedia.Name = "findMedia";
            this.findMedia.Size = new System.Drawing.Size(143, 57);
            this.findMedia.TabIndex = 7;
            this.findMedia.Text = "Find Media";
            this.findMedia.UseVisualStyleBackColor = true;
            this.findMedia.Click += new System.EventHandler(this.findMedia_Click);
            // 
            // addMedia
            // 
            this.addMedia.Location = new System.Drawing.Point(80, 281);
            this.addMedia.Name = "addMedia";
            this.addMedia.Size = new System.Drawing.Size(143, 57);
            this.addMedia.TabIndex = 8;
            this.addMedia.Text = "Add Media";
            this.addMedia.UseVisualStyleBackColor = true;
            this.addMedia.Click += new System.EventHandler(this.addMedia_Click);
            // 
            // findMember
            // 
            this.findMember.Location = new System.Drawing.Point(577, 181);
            this.findMember.Name = "findMember";
            this.findMember.Size = new System.Drawing.Size(143, 57);
            this.findMember.TabIndex = 9;
            this.findMember.Text = "Find Member";
            this.findMember.UseVisualStyleBackColor = true;
            this.findMember.Click += new System.EventHandler(this.findMember_Click);
            // 
            // addMember
            // 
            this.addMember.Location = new System.Drawing.Point(577, 281);
            this.addMember.Name = "addMember";
            this.addMember.Size = new System.Drawing.Size(143, 57);
            this.addMember.TabIndex = 10;
            this.addMember.Text = "Add Member";
            this.addMember.UseVisualStyleBackColor = true;
            this.addMember.Click += new System.EventHandler(this.addMember_Click);
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(782, 453);
            this.Controls.Add(this.addMember);
            this.Controls.Add(this.findMember);
            this.Controls.Add(this.addMedia);
            this.Controls.Add(this.findMedia);
            this.Controls.Add(this.label1);
            this.Name = "Home";
            this.Text = "Home Page";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button findMedia;
        private System.Windows.Forms.Button addMedia;
        private System.Windows.Forms.Button findMember;
        private System.Windows.Forms.Button addMember;
    }
}

