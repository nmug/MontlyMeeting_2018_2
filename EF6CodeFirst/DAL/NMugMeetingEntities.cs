using System.Data.Entity;

namespace EF6CodeFirst.DAL
{
    public partial class NMugMeetingEntities : DbContext
    {
        public NMugMeetingEntities(string connectionString)
            : base(connectionString)
        {
        }

        public NMugMeetingEntities()
            : base("NMugMeetingEntities")
        {
        }

        public DbSet<Member> Members { get; set; }
        public DbSet<MeetingMember> MeetingMembers { get; set; }
        public DbSet<Meeting> Meetings { get; set; }
        public DbSet<Organizer> Organizers { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            //Configure Default Schema
            modelBuilder.HasDefaultSchema("Dbo");

            modelBuilder.Entity<Member>().MapToStoredProcedures();

            //modelBuilder.Entity<LogEntry>().ToTable("LogEntry", "Logging");
            //modelBuilder.Entity<LogEntry>().MapToStoredProcedures();

            //modelBuilder.Entity<AssemblyComponent>()
            //    .HasKey(c => new { c.AssemblyId, c.ComponentId });

            //modelBuilder.Entity<Assembly>()
            //    .HasMany(c => c.AssemblyComponents)
            //    .WithRequired()
            //    .HasForeignKey(c => c.AssemblyId);

            //modelBuilder.Entity<Component>()
            //    .HasMany(c => c.AssemblyComponents)
            //    .WithRequired()
            //    .HasForeignKey(c => c.ComponentId);

            base.OnModelCreating(modelBuilder);
        }

        
    }
}