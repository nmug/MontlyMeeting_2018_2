﻿

// ------------------------------------------------------------------------------------------------
// This code was generated by EntityFramework Reverse POCO Generator (http://www.reversepoco.com/).
// Created by Simon Hughes (https://about.me/simon.hughes).
//
// Do not make changes directly to this file - edit the template instead.
//
// The following connection settings were used to generate this file:
//     Configuration file:     "Ef6DatabaseFirstUsingEfPocoGenerator\Web.config"
//     Connection String Name: "MyDbContext"
//     Connection String:      "data source=localhost;initial catalog=NMUGMeetings;integrated security=True;multipleactiveresultsets=True;application name=EntityFramework"
// ------------------------------------------------------------------------------------------------
// Database Edition       : Developer Edition (64-bit)
// Database Engine Edition: Enterprise

// <auto-generated>
// ReSharper disable ConvertPropertyToExpressionBody
// ReSharper disable DoNotCallOverridableMethodsInConstructor
// ReSharper disable EmptyNamespace
// ReSharper disable InconsistentNaming
// ReSharper disable PartialMethodWithSinglePart
// ReSharper disable PartialTypeWithSinglePart
// ReSharper disable RedundantNameQualifier
// ReSharper disable RedundantOverridenMember
// ReSharper disable UseNameofExpression
// TargetFrameworkVersion = 4.7
#pragma warning disable 1591    //  Ignore "Missing XML Comment" warning


namespace Ef6DatabaseFirstUsingEfPocoGenerator.DAL
{
    using System.Linq;

    #region Unit of work

    public partial interface IMyDbContext : System.IDisposable
    {
        System.Data.Entity.DbSet<admin_Organizer> admin_Organizers { get; set; } // Organizers
        System.Data.Entity.DbSet<Meeting> Meetings { get; set; } // Meetings
        System.Data.Entity.DbSet<MeetingMember> MeetingMembers { get; set; } // MeetingMembers
        System.Data.Entity.DbSet<Member> Members { get; set; } // Members

        int SaveChanges();
        System.Threading.Tasks.Task<int> SaveChangesAsync();
        System.Threading.Tasks.Task<int> SaveChangesAsync(System.Threading.CancellationToken cancellationToken);
        System.Data.Entity.Infrastructure.DbChangeTracker ChangeTracker { get; }
        System.Data.Entity.Infrastructure.DbContextConfiguration Configuration { get; }
        System.Data.Entity.Database Database { get; }
        System.Data.Entity.Infrastructure.DbEntityEntry<TEntity> Entry<TEntity>(TEntity entity) where TEntity : class;
        System.Data.Entity.Infrastructure.DbEntityEntry Entry(object entity);
        System.Collections.Generic.IEnumerable<System.Data.Entity.Validation.DbEntityValidationResult> GetValidationErrors();
        System.Data.Entity.DbSet Set(System.Type entityType);
        System.Data.Entity.DbSet<TEntity> Set<TEntity>() where TEntity : class;
        string ToString();

        // Stored Procedures
        System.Collections.Generic.List<GetMemberMeetingsReturnModel> GetMemberMeetings();
        System.Collections.Generic.List<GetMemberMeetingsReturnModel> GetMemberMeetings(out int procResult);
        System.Threading.Tasks.Task<System.Collections.Generic.List<GetMemberMeetingsReturnModel>> GetMemberMeetingsAsync();

    }

    #endregion

    #region Database context

    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.35.0.0")]
    public partial class MyDbContext : System.Data.Entity.DbContext, IMyDbContext
    {
        public System.Data.Entity.DbSet<admin_Organizer> admin_Organizers { get; set; } // Organizers
        public System.Data.Entity.DbSet<Meeting> Meetings { get; set; } // Meetings
        public System.Data.Entity.DbSet<MeetingMember> MeetingMembers { get; set; } // MeetingMembers
        public System.Data.Entity.DbSet<Member> Members { get; set; } // Members

        static MyDbContext()
        {
            System.Data.Entity.Database.SetInitializer<MyDbContext>(null);
        }

        public MyDbContext()
            : base("Name=MyDbContext")
        {
            InitializePartial();
        }

        public MyDbContext(string connectionString)
            : base(connectionString)
        {
            InitializePartial();
        }

        public MyDbContext(string connectionString, System.Data.Entity.Infrastructure.DbCompiledModel model)
            : base(connectionString, model)
        {
            InitializePartial();
        }

        public MyDbContext(System.Data.Common.DbConnection existingConnection, bool contextOwnsConnection)
            : base(existingConnection, contextOwnsConnection)
        {
            InitializePartial();
        }

        public MyDbContext(System.Data.Common.DbConnection existingConnection, System.Data.Entity.Infrastructure.DbCompiledModel model, bool contextOwnsConnection)
            : base(existingConnection, model, contextOwnsConnection)
        {
            InitializePartial();
        }

        protected override void Dispose(bool disposing)
        {
            base.Dispose(disposing);
        }

        public bool IsSqlParameterNull(System.Data.SqlClient.SqlParameter param)
        {
            var sqlValue = param.SqlValue;
            var nullableValue = sqlValue as System.Data.SqlTypes.INullable;
            if (nullableValue != null)
                return nullableValue.IsNull;
            return (sqlValue == null || sqlValue == System.DBNull.Value);
        }

        protected override void OnModelCreating(System.Data.Entity.DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Configurations.Add(new admin_OrganizerConfiguration());
            modelBuilder.Configurations.Add(new MeetingConfiguration());
            modelBuilder.Configurations.Add(new MeetingMemberConfiguration());
            modelBuilder.Configurations.Add(new MemberConfiguration());

            OnModelCreatingPartial(modelBuilder);
        }

        public static System.Data.Entity.DbModelBuilder CreateModel(System.Data.Entity.DbModelBuilder modelBuilder, string schema)
        {
            modelBuilder.Configurations.Add(new admin_OrganizerConfiguration(schema));
            modelBuilder.Configurations.Add(new MeetingConfiguration(schema));
            modelBuilder.Configurations.Add(new MeetingMemberConfiguration(schema));
            modelBuilder.Configurations.Add(new MemberConfiguration(schema));
            return modelBuilder;
        }

        partial void InitializePartial();
        partial void OnModelCreatingPartial(System.Data.Entity.DbModelBuilder modelBuilder);

        // Stored Procedures
        public System.Collections.Generic.List<GetMemberMeetingsReturnModel> GetMemberMeetings()
        {
            int procResult;
            return GetMemberMeetings(out procResult);
        }

        public System.Collections.Generic.List<GetMemberMeetingsReturnModel> GetMemberMeetings(out int procResult)
        {
            var procResultParam = new System.Data.SqlClient.SqlParameter { ParameterName = "@procResult", SqlDbType = System.Data.SqlDbType.Int, Direction = System.Data.ParameterDirection.Output };
            var procResultData = Database.SqlQuery<GetMemberMeetingsReturnModel>("EXEC @procResult = [dbo].[GetMemberMeetings] ", procResultParam).ToList();

            procResult = (int) procResultParam.Value;
            return procResultData;
        }

        public async System.Threading.Tasks.Task<System.Collections.Generic.List<GetMemberMeetingsReturnModel>> GetMemberMeetingsAsync()
        {
            var procResultData = await Database.SqlQuery<GetMemberMeetingsReturnModel>("EXEC [dbo].[GetMemberMeetings] ").ToListAsync();

            return procResultData;
        }

    }
    #endregion

    #region Database context factory

    public partial class MyDbContextFactory : System.Data.Entity.Infrastructure.IDbContextFactory<MyDbContext>
    {
        public MyDbContext Create()
        {
            return new MyDbContext();
        }
    }

    #endregion

    #region Fake Database context

    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.35.0.0")]
    public partial class FakeMyDbContext : IMyDbContext
    {
        public System.Data.Entity.DbSet<admin_Organizer> admin_Organizers { get; set; }
        public System.Data.Entity.DbSet<Meeting> Meetings { get; set; }
        public System.Data.Entity.DbSet<MeetingMember> MeetingMembers { get; set; }
        public System.Data.Entity.DbSet<Member> Members { get; set; }

        public FakeMyDbContext()
        {
            admin_Organizers = new FakeDbSet<admin_Organizer>("OrganizerId");
            Meetings = new FakeDbSet<Meeting>("MeetingId");
            MeetingMembers = new FakeDbSet<MeetingMember>("MeetingId", "MemberId");
            Members = new FakeDbSet<Member>("MemberId");

            InitializePartial();
        }

        public int SaveChangesCount { get; private set; }
        public int SaveChanges()
        {
            ++SaveChangesCount;
            return 1;
        }

        public System.Threading.Tasks.Task<int> SaveChangesAsync()
        {
            ++SaveChangesCount;
            return System.Threading.Tasks.Task<int>.Factory.StartNew(() => 1);
        }

        public System.Threading.Tasks.Task<int> SaveChangesAsync(System.Threading.CancellationToken cancellationToken)
        {
            ++SaveChangesCount;
            return System.Threading.Tasks.Task<int>.Factory.StartNew(() => 1, cancellationToken);
        }

        partial void InitializePartial();

        protected virtual void Dispose(bool disposing)
        {
        }

        public void Dispose()
        {
            Dispose(true);
        }

        private System.Data.Entity.Infrastructure.DbChangeTracker _changeTracker;
        public System.Data.Entity.Infrastructure.DbChangeTracker ChangeTracker { get { return _changeTracker; } }
        private System.Data.Entity.Infrastructure.DbContextConfiguration _configuration;
        public System.Data.Entity.Infrastructure.DbContextConfiguration Configuration { get { return _configuration; } }
        private System.Data.Entity.Database _database;
        public System.Data.Entity.Database Database { get { return _database; } }
        public System.Data.Entity.Infrastructure.DbEntityEntry<TEntity> Entry<TEntity>(TEntity entity) where TEntity : class
        {
            throw new System.NotImplementedException();
        }
        public System.Data.Entity.Infrastructure.DbEntityEntry Entry(object entity)
        {
            throw new System.NotImplementedException();
        }
        public System.Collections.Generic.IEnumerable<System.Data.Entity.Validation.DbEntityValidationResult> GetValidationErrors()
        {
            throw new System.NotImplementedException();
        }
        public System.Data.Entity.DbSet Set(System.Type entityType)
        {
            throw new System.NotImplementedException();
        }
        public System.Data.Entity.DbSet<TEntity> Set<TEntity>() where TEntity : class
        {
            throw new System.NotImplementedException();
        }
        public override string ToString()
        {
            throw new System.NotImplementedException();
        }


        // Stored Procedures
        public System.Collections.Generic.List<GetMemberMeetingsReturnModel> GetMemberMeetings()
        {
            int procResult;
            return GetMemberMeetings(out procResult);
        }

        public System.Collections.Generic.List<GetMemberMeetingsReturnModel> GetMemberMeetings(out int procResult)
        {

            procResult = 0;
            return new System.Collections.Generic.List<GetMemberMeetingsReturnModel>();
        }

        public System.Threading.Tasks.Task<System.Collections.Generic.List<GetMemberMeetingsReturnModel>> GetMemberMeetingsAsync()
        {
            int procResult;
            return System.Threading.Tasks.Task.FromResult(GetMemberMeetings(out procResult));
        }

    }

    // ************************************************************************
    // Fake DbSet
    // Implementing Find:
    //      The Find method is difficult to implement in a generic fashion. If
    //      you need to test code that makes use of the Find method it is
    //      easiest to create a test DbSet for each of the entity types that
    //      need to support find. You can then write logic to find that
    //      particular type of entity, as shown below:
    //      public class FakeBlogDbSet : FakeDbSet<Blog>
    //      {
    //          public override Blog Find(params object[] keyValues)
    //          {
    //              var id = (int) keyValues.Single();
    //              return this.SingleOrDefault(b => b.BlogId == id);
    //          }
    //      }
    //      Read more about it here: https://msdn.microsoft.com/en-us/data/dn314431.aspx
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.35.0.0")]
    public partial class FakeDbSet<TEntity> : System.Data.Entity.DbSet<TEntity>, IQueryable, System.Collections.Generic.IEnumerable<TEntity>, System.Data.Entity.Infrastructure.IDbAsyncEnumerable<TEntity> where TEntity : class
    {
        private readonly System.Reflection.PropertyInfo[] _primaryKeys;
        private readonly System.Collections.ObjectModel.ObservableCollection<TEntity> _data;
        private readonly IQueryable _query;

        public FakeDbSet()
        {
            _data = new System.Collections.ObjectModel.ObservableCollection<TEntity>();
            _query = _data.AsQueryable();

            InitializePartial();
        }

        public FakeDbSet(params string[] primaryKeys)
        {
            _primaryKeys = typeof(TEntity).GetProperties().Where(x => primaryKeys.Contains(x.Name)).ToArray();
            _data = new System.Collections.ObjectModel.ObservableCollection<TEntity>();
            _query = _data.AsQueryable();

            InitializePartial();
        }

        public override TEntity Find(params object[] keyValues)
        {
            if (_primaryKeys == null)
                throw new System.ArgumentException("No primary keys defined");
            if (keyValues.Length != _primaryKeys.Length)
                throw new System.ArgumentException("Incorrect number of keys passed to Find method");

            var keyQuery = this.AsQueryable();
            keyQuery = keyValues
                .Select((t, i) => i)
                .Aggregate(keyQuery,
                    (current, x) =>
                        current.Where(entity => _primaryKeys[x].GetValue(entity, null).Equals(keyValues[x])));

            return keyQuery.SingleOrDefault();
        }

        public override System.Threading.Tasks.Task<TEntity> FindAsync(System.Threading.CancellationToken cancellationToken, params object[] keyValues)
        {
            return System.Threading.Tasks.Task<TEntity>.Factory.StartNew(() => Find(keyValues), cancellationToken);
        }

        public override System.Threading.Tasks.Task<TEntity> FindAsync(params object[] keyValues)
        {
            return System.Threading.Tasks.Task<TEntity>.Factory.StartNew(() => Find(keyValues));
        }

        public override System.Collections.Generic.IEnumerable<TEntity> AddRange(System.Collections.Generic.IEnumerable<TEntity> entities)
        {
            if (entities == null) throw new System.ArgumentNullException("entities");
            var items = entities.ToList();
            foreach (var entity in items)
            {
                _data.Add(entity);
            }
            return items;
        }

        public override TEntity Add(TEntity item)
        {
            if (item == null) throw new System.ArgumentNullException("item");
            _data.Add(item);
            return item;
        }

        public override System.Collections.Generic.IEnumerable<TEntity> RemoveRange(System.Collections.Generic.IEnumerable<TEntity> entities)
        {
            if (entities == null) throw new System.ArgumentNullException("entities");
            var items = entities.ToList();
            foreach (var entity in items)
            {
                _data.Remove(entity);
            }
            return items;
        }

        public override TEntity Remove(TEntity item)
        {
            if (item == null) throw new System.ArgumentNullException("item");
            _data.Remove(item);
            return item;
        }

        public override TEntity Attach(TEntity item)
        {
            if (item == null) throw new System.ArgumentNullException("item");
            _data.Add(item);
            return item;
        }

        public override TEntity Create()
        {
            return System.Activator.CreateInstance<TEntity>();
        }

        public override TDerivedEntity Create<TDerivedEntity>()
        {
            return System.Activator.CreateInstance<TDerivedEntity>();
        }

        public override System.Collections.ObjectModel.ObservableCollection<TEntity> Local
        {
            get { return _data; }
        }

        System.Type IQueryable.ElementType
        {
            get { return _query.ElementType; }
        }

        System.Linq.Expressions.Expression IQueryable.Expression
        {
            get { return _query.Expression; }
        }

        IQueryProvider IQueryable.Provider
        {
            get { return new FakeDbAsyncQueryProvider<TEntity>(_query.Provider); }
        }

        System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
        {
            return _data.GetEnumerator();
        }

        System.Collections.Generic.IEnumerator<TEntity> System.Collections.Generic.IEnumerable<TEntity>.GetEnumerator()
        {
            return _data.GetEnumerator();
        }

        System.Data.Entity.Infrastructure.IDbAsyncEnumerator<TEntity> System.Data.Entity.Infrastructure.IDbAsyncEnumerable<TEntity>.GetAsyncEnumerator()
        {
            return new FakeDbAsyncEnumerator<TEntity>(_data.GetEnumerator());
        }

        partial void InitializePartial();
    }

    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.35.0.0")]
    public class FakeDbAsyncQueryProvider<TEntity> : System.Data.Entity.Infrastructure.IDbAsyncQueryProvider
    {
        private readonly IQueryProvider _inner;

        public FakeDbAsyncQueryProvider(IQueryProvider inner)
        {
            _inner = inner;
        }

        public IQueryable CreateQuery(System.Linq.Expressions.Expression expression)
        {
            return new FakeDbAsyncEnumerable<TEntity>(expression);
        }

        public IQueryable<TElement> CreateQuery<TElement>(System.Linq.Expressions.Expression expression)
        {
            return new FakeDbAsyncEnumerable<TElement>(expression);
        }

        public object Execute(System.Linq.Expressions.Expression expression)
        {
            return _inner.Execute(expression);
        }

        public TResult Execute<TResult>(System.Linq.Expressions.Expression expression)
        {
            return _inner.Execute<TResult>(expression);
        }

        public System.Threading.Tasks.Task<object> ExecuteAsync(System.Linq.Expressions.Expression expression, System.Threading.CancellationToken cancellationToken)
        {
            return System.Threading.Tasks.Task.FromResult(Execute(expression));
        }

        public System.Threading.Tasks.Task<TResult> ExecuteAsync<TResult>(System.Linq.Expressions.Expression expression, System.Threading.CancellationToken cancellationToken)
        {
            return System.Threading.Tasks.Task.FromResult(Execute<TResult>(expression));
        }
    }

    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.35.0.0")]
    public class FakeDbAsyncEnumerable<T> : EnumerableQuery<T>, System.Data.Entity.Infrastructure.IDbAsyncEnumerable<T>, IQueryable<T>
    {
        public FakeDbAsyncEnumerable(System.Collections.Generic.IEnumerable<T> enumerable)
            : base(enumerable)
        { }

        public FakeDbAsyncEnumerable(System.Linq.Expressions.Expression expression)
            : base(expression)
        { }

        public System.Data.Entity.Infrastructure.IDbAsyncEnumerator<T> GetAsyncEnumerator()
        {
            return new FakeDbAsyncEnumerator<T>(this.AsEnumerable().GetEnumerator());
        }

        System.Data.Entity.Infrastructure.IDbAsyncEnumerator System.Data.Entity.Infrastructure.IDbAsyncEnumerable.GetAsyncEnumerator()
        {
            return GetAsyncEnumerator();
        }

        IQueryProvider IQueryable.Provider
        {
            get { return new FakeDbAsyncQueryProvider<T>(this); }
        }
    }

    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.35.0.0")]
    public class FakeDbAsyncEnumerator<T> : System.Data.Entity.Infrastructure.IDbAsyncEnumerator<T>
    {
        private readonly System.Collections.Generic.IEnumerator<T> _inner;

        public FakeDbAsyncEnumerator(System.Collections.Generic.IEnumerator<T> inner)
        {
            _inner = inner;
        }

        public void Dispose()
        {
            _inner.Dispose();
        }

        public System.Threading.Tasks.Task<bool> MoveNextAsync(System.Threading.CancellationToken cancellationToken)
        {
            return System.Threading.Tasks.Task.FromResult(_inner.MoveNext());
        }

        public T Current
        {
            get { return _inner.Current; }
        }

        object System.Data.Entity.Infrastructure.IDbAsyncEnumerator.Current
        {
            get { return Current; }
        }
    }

    #endregion

    #region POCO classes

    // Organizers
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.35.0.0")]
    public partial class admin_Organizer
    {
        public int OrganizerId { get; set; } // OrganizerId (Primary key)
        public int MemberId { get; set; } // MemberId

        // Foreign keys

        /// <summary>
        /// Parent Member pointed by [Organizers].([MemberId]) (FK_Organizers_Members)
        /// </summary>
        public virtual Member Member { get; set; } // FK_Organizers_Members

        public admin_Organizer()
        {
            InitializePartial();
        }

        partial void InitializePartial();
    }

    // Meetings
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.35.0.0")]
    public partial class Meeting
    {
        public int MeetingId { get; set; } // MeetingId (Primary key)
        public string Name { get; set; } // Name (length: 50)
        public string Description { get; set; } // Description (length: 50)

        // Reverse navigation

        /// <summary>
        /// Child MeetingMembers where [MeetingMembers].[MeetingId] point to this entity (FK_MeetingMembers_Meetings)
        /// </summary>
        public virtual System.Collections.Generic.ICollection<MeetingMember> MeetingMembers { get; set; } // MeetingMembers.FK_MeetingMembers_Meetings

        public Meeting()
        {
            MeetingMembers = new System.Collections.Generic.List<MeetingMember>();
            InitializePartial();
        }

        partial void InitializePartial();
    }

    // MeetingMembers
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.35.0.0")]
    public partial class MeetingMember
    {
        public int MeetingId { get; set; } // MeetingId (Primary key)
        public int MemberId { get; set; } // MemberId (Primary key)
        public bool IsAttending { get; set; } // IsAttending
        public System.DateTime LastUpdated { get; set; } // LastUpdated

        // Foreign keys

        /// <summary>
        /// Parent Meeting pointed by [MeetingMembers].([MeetingId]) (FK_MeetingMembers_Meetings)
        /// </summary>
        public virtual Meeting Meeting { get; set; } // FK_MeetingMembers_Meetings

        /// <summary>
        /// Parent Member pointed by [MeetingMembers].([MemberId]) (FK_MeetingMembers_Members)
        /// </summary>
        public virtual Member Member { get; set; } // FK_MeetingMembers_Members

        public MeetingMember()
        {
            InitializePartial();
        }

        partial void InitializePartial();
    }

    // Members
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.35.0.0")]
    public partial class Member
    {
        public int MemberId { get; set; } // MemberId (Primary key)
        public string FirstName { get; set; } // FirstName (length: 50)
        public string LastName { get; set; } // LastName (length: 50)
        public string EmailAddress { get; set; } // EmailAddress (length: 50)

        // Reverse navigation

        /// <summary>
        /// Child admin_Organizers where [Organizers].[MemberId] point to this entity (FK_Organizers_Members)
        /// </summary>
        public virtual System.Collections.Generic.ICollection<admin_Organizer> admin_Organizers { get; set; } // Organizers.FK_Organizers_Members
        /// <summary>
        /// Child MeetingMembers where [MeetingMembers].[MemberId] point to this entity (FK_MeetingMembers_Members)
        /// </summary>
        public virtual System.Collections.Generic.ICollection<MeetingMember> MeetingMembers { get; set; } // MeetingMembers.FK_MeetingMembers_Members

        public Member()
        {
            admin_Organizers = new System.Collections.Generic.List<admin_Organizer>();
            MeetingMembers = new System.Collections.Generic.List<MeetingMember>();
            InitializePartial();
        }

        partial void InitializePartial();
    }

    #endregion

    #region POCO Configuration

    // Organizers
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.35.0.0")]
    public partial class admin_OrganizerConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<admin_Organizer>
    {
        public admin_OrganizerConfiguration()
            : this("admin")
        {
        }

        public admin_OrganizerConfiguration(string schema)
        {
            ToTable("Organizers", schema);
            HasKey(x => x.OrganizerId);

            Property(x => x.OrganizerId).HasColumnName(@"OrganizerId").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.MemberId).HasColumnName(@"MemberId").HasColumnType("int").IsRequired();

            // Foreign keys
            HasRequired(a => a.Member).WithMany(b => b.admin_Organizers).HasForeignKey(c => c.MemberId).WillCascadeOnDelete(false); // FK_Organizers_Members
            InitializePartial();
        }
        partial void InitializePartial();
    }

    // Meetings
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.35.0.0")]
    public partial class MeetingConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<Meeting>
    {
        public MeetingConfiguration()
            : this("dbo")
        {
        }

        public MeetingConfiguration(string schema)
        {
            ToTable("Meetings", schema);
            HasKey(x => x.MeetingId);

            Property(x => x.MeetingId).HasColumnName(@"MeetingId").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.Name).HasColumnName(@"Name").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(50);
            Property(x => x.Description).HasColumnName(@"Description").HasColumnType("nvarchar").IsOptional().HasMaxLength(50);
            InitializePartial();
        }
        partial void InitializePartial();
    }

    // MeetingMembers
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.35.0.0")]
    public partial class MeetingMemberConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<MeetingMember>
    {
        public MeetingMemberConfiguration()
            : this("dbo")
        {
        }

        public MeetingMemberConfiguration(string schema)
        {
            ToTable("MeetingMembers", schema);
            HasKey(x => new { x.MeetingId, x.MemberId });

            Property(x => x.MeetingId).HasColumnName(@"MeetingId").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.MemberId).HasColumnName(@"MemberId").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.None);
            Property(x => x.IsAttending).HasColumnName(@"IsAttending").HasColumnType("bit").IsRequired();
            Property(x => x.LastUpdated).HasColumnName(@"LastUpdated").HasColumnType("datetime").IsRequired();

            // Foreign keys
            HasRequired(a => a.Meeting).WithMany(b => b.MeetingMembers).HasForeignKey(c => c.MeetingId).WillCascadeOnDelete(false); // FK_MeetingMembers_Meetings
            HasRequired(a => a.Member).WithMany(b => b.MeetingMembers).HasForeignKey(c => c.MemberId).WillCascadeOnDelete(false); // FK_MeetingMembers_Members
            InitializePartial();
        }
        partial void InitializePartial();
    }

    // Members
    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.35.0.0")]
    public partial class MemberConfiguration : System.Data.Entity.ModelConfiguration.EntityTypeConfiguration<Member>
    {
        public MemberConfiguration()
            : this("dbo")
        {
        }

        public MemberConfiguration(string schema)
        {
            ToTable("Members", schema);
            HasKey(x => x.MemberId);

            Property(x => x.MemberId).HasColumnName(@"MemberId").HasColumnType("int").IsRequired().HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(x => x.FirstName).HasColumnName(@"FirstName").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(50);
            Property(x => x.LastName).HasColumnName(@"LastName").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(50);
            Property(x => x.EmailAddress).HasColumnName(@"EmailAddress").HasColumnType("varchar").IsRequired().IsUnicode(false).HasMaxLength(50);
            InitializePartial();
        }
        partial void InitializePartial();
    }

    #endregion

    #region Stored procedure return models

    [System.CodeDom.Compiler.GeneratedCode("EF.Reverse.POCO.Generator", "2.35.0.0")]
    public partial class GetMemberMeetingsReturnModel
    {
        public System.String Name { get; set; }
        public System.String Description { get; set; }
        public System.String FirstName { get; set; }
        public System.String LastNAme { get; set; }
        public System.String EmailAddress { get; set; }
    }

    #endregion

}
// </auto-generated>
