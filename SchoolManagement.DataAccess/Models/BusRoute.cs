using System;
using System.Collections.Generic;

namespace SchoolManagement.DataAccess.Models
{
    public partial class BusRoute
    {
        public BusRoute()
        {
            Student = new HashSet<Student>();
        }

        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public Guid LocationId { get; set; }
        public Guid StatusId { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }

        public virtual Location Location { get; set; }
        public virtual Status Status { get; set; }
        public virtual ICollection<Student> Student { get; set; }
    }
}
