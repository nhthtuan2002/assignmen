using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Student.Models
{
    public class StudentModel
    {
        public string Id { get; set; }
        public string SubmissionForm { get; set; }
        public string Money { get; set; }
        public DateTime create_at { get; set; }
    }
}