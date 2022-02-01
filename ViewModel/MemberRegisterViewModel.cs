using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

using Tedliu.WebApp.sideProject.Models;

namespace Tedliu.WebApp.sideProject.ViewModel
{
    public class MemberRegisterViewModel
    {
        public Member newMember {get;set;}

        [DisplayName("密碼")]
        [Required(ErrorMessage ="請輸入密碼")]
        public string Password { get; set; }

        [DisplayName("確認密碼")]
        [Compare("Password", ErrorMessage ="兩次密碼輸入不一樣")]
        [Required(ErrorMessage = "請輸入確認密碼")]

        public string PasswordCheck { get; set; }


    }
}