namespace EF6DatabaseFirstUsingModels.DAL
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class MeetingMember
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int MeetingId { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int MemberId { get; set; }

        public bool IsAttending { get; set; }

        public DateTime LastUpdated { get; set; }

        public virtual Meeting Meeting { get; set; }

        public virtual Member Member { get; set; }
    }
}
