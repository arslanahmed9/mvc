﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MyFirstProject.ViewModels
{
    //view models
    public class Course_Students
    {
        public Course course { get; set; }
        public List<Student> students { get; set; }
    }
}