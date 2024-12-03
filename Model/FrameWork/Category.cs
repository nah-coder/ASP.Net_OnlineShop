namespace Model.FrameWork
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Category")]
    public partial class Category
    {
        public long ID { get; set; }

        [Required]
        [StringLength(50)]
        public string Name { get; set; }

        [Required]
        [StringLength(50)]
        public string MetaTitle { get; set; }

        public long ParentID { get; set; }

        public int DisplayOrder { get; set; }

        [Required]
        [StringLength(50)]
        public string SeoTitle { get; set; }

        public DateTime CreateDate { get; set; }

        [Required]
        [StringLength(50)]
        public string CreateBy { get; set; }

        public DateTime ModifiedDate { get; set; }

        [Required]
        [StringLength(50)]
        public string ModifiedBy { get; set; }

        [Required]
        [StringLength(50)]
        public string MetaKeyword { get; set; }

        [Required]
        [StringLength(50)]
        public string MetaDescription { get; set; }

        public bool Status { get; set; }

        public bool ShowOnHome { get; set; }
    }
}
