using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;

namespace phillips_james_semesterProject
{
    [Serializable]
    public class Member
    {
        // member class contains the member id and member's name
        // thought about adding a list of checked out items, but figured it could be added later
        // if time permits

        int memberID;
        string name;
        public static List<Member> memberList = new List<Member>();
        //List<Media> checkedOut;

        public Member(string name, int memberID)
        {
            this.Name = name;
            this.MemberID = memberID;
        }

        public string Name { get; set; }
        public int MemberID { get; set; }
        //public List<Media> CheckedOut { get; set; }

        public override string ToString()
        {
            string memberString = string.Format("{0}. {1}", this.MemberID, this.Name);
            return memberString;
        }
    }
}
