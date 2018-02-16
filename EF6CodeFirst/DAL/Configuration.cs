using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Web;

namespace EF6CodeFirst.DAL
{
    internal sealed class Configuration : DbMigrationsConfiguration<NMugMeetingEntities>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }


        /// <summary>
        /// TODO: Remove test data before pusing to Production
        /// </summary>
        /// <param name="context"></param>
        protected override void Seed(NMugMeetingEntities context)
        {

            if (context.Members.Count() == 0)
            {
                context.Members.AddRange(new List<Member>
                {
                    new Member() {  FirstName = "FirstName1", LastName = "LastName 1", EmailAddress = "emailAddress1" },
                    new Member() {  FirstName = "FirstName2", LastName = "LastName 2", EmailAddress = "emailAddress2" },
                    new Member() {  FirstName = "FirstName3", LastName = "LastName 3", EmailAddress = "emailAddress3" },
                });

                context.SaveChanges();
            }

            if (context.Meetings.Count() == 0)
            {
                context.Meetings.AddRange(new List<Meeting>
                {
                    new Meeting() { MeetingId = 1},
                    new Meeting() { MeetingId = 2},
                    new Meeting() { MeetingId = 3}
                });

                context.SaveChanges();
            }

            if (context.MeetingMembers.Count() == 0)
            {
                List<Member> memberList = context.Members.ToList();
                List<Meeting> meetingList = context.Meetings.ToList();

                for (int x = 0; x < 3; x++)
                {
                    MeetingMember meetingMember = new MeetingMember
                    {
                        Meeting = meetingList[x],
                        Member = memberList[x],
                        CreationDateTime = DateTime.Now,
                        IsAttending = true
                    };

                    context.MeetingMembers.Add(meetingMember);
                }

                context.SaveChanges();

            }
        }

    }
}