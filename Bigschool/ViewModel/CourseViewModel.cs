using Bigschool.Models;
using Microsoft.Build.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Bigschool.ViewModel
{
    public class CourseViewModel
    {
        [Required]
        public string place { get; set; }
        [Required]
        public string date { get; set; }
        [Required]
        public string time { get; set; }
        [Required]
        public string category { get; set; }
        public IEnumerable<Category> categories { get; set; }
        public DateTime Getdatetime()
        {
            return DateTime.Parse(string.Format("{0} {1}", date, time));
        }

    }
}