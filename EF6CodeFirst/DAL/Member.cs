using System.Collections.Generic;

namespace EF6CodeFirst.DAL
{
    public class Member
    {
        public int MemberId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string EmailAddress { get; set; }

        public virtual ICollection<MeetingMember> MeetingMembers { get; set; }
    }
}