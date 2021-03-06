﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;

namespace MVC_EF6_Example.Models
{
    public class LoginViewModel
    {
        [Display(Name ="Login ID")]
        [Required(ErrorMessage ="*")]
        public int LoginID { get; set; }
        [Display(Name ="Password")]
        [Required(ErrorMessage ="*")]
        public string Password { get; set; }
    }
}