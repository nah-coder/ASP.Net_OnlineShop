namespace Model.FrameWork
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ContentTag")]
    public partial class ContentTag
    {
        [Column("ContentTag")]
        public long ContentTag1 { get; set; }

        [Key]
        [StringLength(50)]
        public string TagID { get; set; }
    }
}
