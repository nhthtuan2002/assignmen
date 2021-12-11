using Student.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Student.Data
{
    public class MyDbContext:DbContext
    {
        public MyDbContext() : base("name = MyDbContext ")
        {

        }
        public DbSet<StudentModel> StudentModels { get; set; }
    }
}