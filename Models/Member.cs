namespace Tedliu.WebApp.sideProject.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;
    using System.Web.Mvc;

    public partial class Member
    {
        [Key]
        [StringLength(50)]
        [DisplayName("帳號")]
        [Remote("AccountCheck","Member",ErrorMessage ="此帳號已經被註冊過")]
        public string Account { get; set; }

        [Required]
        [StringLength(50)]
        public string Password { get; set; }

        [Required]
        [StringLength(50)]
        [DisplayName("姓名")]
        public string Name { get; set; }

        [Required]
        [StringLength(50)]
        [DisplayName("Email")]
        [EmailAddress(ErrorMessage ="這不是Email格式")]
        public string Email { get; set; }

        [Required]
        [StringLength(10)]
        public string AuthCode { get; set; }

        public bool IsAdmin { get; set; }
    }
}
