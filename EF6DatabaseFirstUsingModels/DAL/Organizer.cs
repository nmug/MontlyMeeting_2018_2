namespace EF6DatabaseFirstUsingModels.DAL
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("admin.Organizers")]
    public partial class Organizer
    {
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int OrganizerId { get; set; }

        public int MemberId { get; set; }

        public virtual Member Member { get; set; }
    }
}
