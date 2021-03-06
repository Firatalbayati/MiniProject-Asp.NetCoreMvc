﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MiniProject.Models
{

    public interface ICourseRepository
    {

        IQueryable<Course> Courses { get; }

        Course GetById(int courseid);

        IEnumerable<Course> GetCourses();
        IEnumerable<Course> GetCoursesByActive(bool IsActive);
        IEnumerable<Course> GetCoursesByFilters(string name = null, decimal? price = null, string isActive = null);


        int CreateCourse(Course newCourse);

        void UpdateCourse(Course updatedCourse, Course originalCourse = null);

        void DeleteCourse(int courseid);

        void UpdateAll(int Id, Course[] courses);
    }
}
