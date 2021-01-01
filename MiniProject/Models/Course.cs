﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MiniProject.Models
{
    public class Course 
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public decimal price { get; set; }
        public bool   IsActive { get; set; }   

        public int InstructorId { get; set; }  
        public Instructor Instructor { get; set; }  

        public IEnumerable<StudentCourse> StudentCourses { get; set; }

    }
}
