namespace EF6DatabaseFirstUsingModels.DAL
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class NMugEntities : DbContext
    {
        public NMugEntities()
            : base("name=NMugEntities")
        {
        }

        public virtual DbSet<Organizer> Organizers { get; set; }
        public virtual DbSet<MeetingMember> MeetingMembers { get; set; }
        public virtual DbSet<Meeting> Meetings { get; set; }
        public virtual DbSet<Member> Members { get; set; }
        public virtual DbSet<sysdiagram> sysdiagrams { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Meeting>()
                .Property(e => e.Name)
                .IsUnicode(false);

            modelBuilder.Entity<Meeting>()
                .HasMany(e => e.MeetingMembers)
                .WithRequired(e => e.Meeting)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Member>()
                .Property(e => e.FirstName)
                .IsUnicode(false);

            modelBuilder.Entity<Member>()
                .Property(e => e.LastName)
                .IsUnicode(false);

            modelBuilder.Entity<Member>()
                .Property(e => e.EmailAddress)
                .IsUnicode(false);

            modelBuilder.Entity<Member>()
                .HasMany(e => e.Organizers)
                .WithRequired(e => e.Member)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Member>()
                .HasMany(e => e.MeetingMembers)
                .WithRequired(e => e.Member)
                .WillCascadeOnDelete(false);
        }
    }
}
