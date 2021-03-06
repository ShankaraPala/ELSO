namespace ELSO.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ANNL_RCURPATRN_MNTHS")]
    public partial class MonthlyRecurrance : BaseEntity
    {
        [Key]
        [Column("MNTH_UID", Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int ID { get; set; }

        [Key]
        [Column("RCURPATRN_UID", Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int RecurrenceId { get; set; }

        public virtual Monthly Monthly { get; set; }

        public virtual Pattern MReccurence { get; set; }
    }
}
