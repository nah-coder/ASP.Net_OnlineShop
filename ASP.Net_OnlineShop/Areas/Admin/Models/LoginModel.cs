﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ASP.Net_OnlineShop.Areas.Admin.Models
{
    public class LoginModel
    {
        [Required(ErrorMessage = "Mời nhập UserName")]
        public string UserName { get; set; }
        [Required(ErrorMessage = "Mời nhập PassWord")]
        public string Password { get; set; }
        public bool RememberMe { get; set; }
    }
}