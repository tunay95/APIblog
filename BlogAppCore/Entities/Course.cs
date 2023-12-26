﻿using BlogApp.Core.Entities.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlogApp.Core.Entities
{
	public class Course: BaseAuditableEntity
	{
        public string Title { get; set; }
        public string Description { get; set; }
        public int TeacherId { get; set; }
        public Teacher Teacher { get; set;}
        public List<StudentsCourses> StudentsCourses { get; set; }
    }
}
