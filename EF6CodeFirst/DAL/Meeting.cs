using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EF6CodeFirst.DAL
{
    public class Meeting
    {
        public int MeetingId { get; set; }

        public virtual ICollection<MeetingMember> MeetingMembers {get;set;}
    }
}