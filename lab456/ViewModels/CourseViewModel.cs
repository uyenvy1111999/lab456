using lab456.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace lab456.ViewModels
{
    public class CourseViewModel
    {
        [Recquired]
        public string Place { get; set; }
        [Recquired]
        public string Date { get; set; }
        [Recquired]
        public string Time { get; set; }
        [Recquired]
        public byte Category { get; set; }
        public IEnumerable<Category> Categories { get; set; }
        
        public DateTime GetDateTime()
        {
            return DateTime.Parse(string.Format("{0} {1}", Date, Time));
        }
    }

}