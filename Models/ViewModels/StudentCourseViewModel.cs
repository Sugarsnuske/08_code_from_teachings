using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ConsoleApplication.Models.Entities
{
    public class StudentCourseViewModel
    {
       public Student Student { get; set; }
       public IEnumerable<Course> Courses { get; set; }

    }
}