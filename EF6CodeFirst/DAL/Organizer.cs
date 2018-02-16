using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EF6CodeFirst.DAL
{
    public class Organizer
    {
        public int OrganizerId { get; set; }
        public int MemberId { get; set; }

        public virtual Member Member { get; set; }
    }
}