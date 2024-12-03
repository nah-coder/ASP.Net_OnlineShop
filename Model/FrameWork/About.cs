namespace Model.FrameWork
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("About")]
    public partial class About
    {
        public long ID { get; set; }

        [StringLength(50)]
        public string Name { get; set; }

        [StringLength(50)]
        public string MetaTitle { get; set; }

        [StringLength(50)]
        public string Description { get; set; }

        [StringLength(50)]
        public string Image { get; set; }

        [Column(TypeName = "ntext")]
        public string Detail { get; set; }

        public DateTime? CreateDate { get; set; }

        [StringLength(50)]
        public string CreateBy { get; set; }

        public DateTime? ModifiedDate { get; set; }

        [StringLength(50)]
        public string ModifiedBy { get; set; }

        [StringLength(50)]
        public string MetaKeyword { get; set; }

        [StringLength(50)]
        public string MetaDescription { get; set; }

        public bool? Status { get; set; }
    }
}
