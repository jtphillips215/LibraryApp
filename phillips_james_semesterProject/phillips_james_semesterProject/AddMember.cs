using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace phillips_james_semesterProject
{
    public partial class AddMemberForm : Form
    {
        public AddMemberForm()
        {
            InitializeComponent();
            Helpers.ReadMembers();
        }

        private void addMemberButton_Click(object sender, EventArgs e)
        {
            // calls helper function to create member, add member to list, clear boxes,
            // and give success or fail message to user
            // member written to file if successful and an error message is
            // presented if not
            try
            {
                Helpers.AddMember(nameTextBox.Text, memberIDTextBox.Text);
                nameTextBox.Clear();
                memberIDTextBox.Clear();
                Helpers.WriteMembers(Member.memberList);
                Helpers.ReadMembers();
                SuccessLabel.Visible = true;
            }
            catch (FormatException)
            {
                FailLabel.Visible = true;
            }
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            AddMemberForm.ActiveForm.Close();
        }
    }
}
