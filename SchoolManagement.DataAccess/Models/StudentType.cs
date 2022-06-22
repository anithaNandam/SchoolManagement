﻿using System;
using System.Collections.Generic;

namespace SchoolManagement.DataAccess.Models
{
    public partial class StudentType
    {
        public StudentType()
        {
            Student = new HashSet<Student>();
            StudentFeeDiscount = new HashSet<StudentFeeDiscount>();
        }

        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public Guid StatusId { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }

        public virtual Status Status { get; set; }
        public virtual ICollection<Student> Student { get; set; }
        public virtual ICollection<StudentFeeDiscount> StudentFeeDiscount { get; set; }
    }
}
