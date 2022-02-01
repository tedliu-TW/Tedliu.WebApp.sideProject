namespace Tedliu.WebApp.sideProject.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Guestbook
    {
        public int id { get; set; }

        [Required]
        [StringLength(50)]
        public string Account { get; set; }

        [Required]
        [StringLength(50)]
        public string Content { get; set; }

        public DateTime CreateTime { get; set; }

        [StringLength(50)]
        public string Reply { get; set; }

        public DateTime? ReplyTime { get; set; }
    }
}
