//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ELSO.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SESN_WEB_RSRC")]
    public partial class SessionWebResource : BaseEntity
    {
        [Key]
        [Column("RCURPATRN_SESN_UID")]
        public int SessionId { get; set; }

        [Column("WEB_RSRC_UID")]
        public int WebResourceId { get; set; }
    
        public virtual Session Session { get; set; }
        public virtual WebResource WebResource { get; set; }
    }
}
