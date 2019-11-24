using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace rest.DTOs
{
    public class AddCourseRequest
    {
        public string Title {get; set;}
        public string Description { get; set; }
    }
}