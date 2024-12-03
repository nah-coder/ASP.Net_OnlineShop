namespace Model.FrameWork
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Tag")]
    public partial class Tag
    {
        [MaxLength(50)]
        public byte[] ID { get; set; }

        [StringLength(50)]
        public string Name { get; set; }
    }
}
