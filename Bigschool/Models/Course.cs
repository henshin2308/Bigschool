using Microsoft.Build.Framework.XamlTypes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Bigschool.Models
{
    public class Course
    {
        public int Id { get; set; }

        public ApplicationUser lecturer { get; set; }
        [Required]
        [StringLength(255)]
        public string place { get; set; }
        public DateTime datetime { get; set; }
        public Category category { get; set; }
        [Required]
        public byte categoryid { get; set; }
    }
    
}