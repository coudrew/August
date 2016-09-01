using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ShowInvite.Models
{
    public class GuestResponse
    {
        [Required(ErrorMessage = "Enter your name")]
        public string name { get; set; }

        [Required(ErrorMessage = "Give me your email")]
        [RegularExpression(@"^[a-z]\w+@\w+.[a-z]{2}.{0,1}[a-z]{0,2}$", ErrorMessage = "invalid")]
        public string email { get; set; }


        public string phone { get; set; }

        [Required(ErrorMessage = "Are you comin or not?")]
        public bool? attending { get; set; }

    }
}