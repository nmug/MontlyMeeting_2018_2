using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace EF6CodeFirst.DAL
{
    public class MeetingMember
    {
        [Key, Column(Order = 0)]
        [ForeignKey("Member")]
        public int MemberId { get; set; }

        [Key, Column(Order = 1)]
        [ForeignKey("Meeting")]
        public int MeetingId { get; set; }

        public bool IsAttending { get; set; }
        public DateTime CreationDateTime {get;set;}

        //Navigation Property
        public virtual Member Member { get; set; }
        public virtual Meeting Meeting { get; set; }
    }
}