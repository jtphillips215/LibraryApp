using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace phillips_james_semesterProject
{
    public partial class FindMemberForm : Form
    {
        public FindMemberForm()
        {
            InitializeComponent();
            PopulateMembers();
        }

        private void FindMemberForm_Load(object sender, EventArgs e)
        {

        }

        public void PopulateMembers()
        {
            // clearing list box and adding frash copy of the list to the list box
            Helpers.ReadMembers();
            membersResults.Items.Clear();
            // sorting the member list by member ID for UI improvements to list box
            Member.memberList.Sort(delegate (Member x, Member y)
            {
                return x.MemberID.CompareTo(y.MemberID);
            });
            membersResults.Items.AddRange(Member.memberList.ToArray());
        }

        private void deleteMemberButton_Click(object sender, EventArgs e)
        {
            // defining selected item as person to delete
            Member member = membersResults.SelectedItem as Member;

            // deleting that person and refreshing the list box
            membersResults.Items.Remove(member);
            Helpers.RemoveMember(member);
            Helpers.WriteMembers(Member.memberList);
            PopulateMembers();
            DeletedLabel.Visible = true;

        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            FindMemberForm.ActiveForm.Close();
        }
    }
}
