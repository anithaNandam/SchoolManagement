using System;

namespace SchoolManagement.Model
{
    public class Section
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public Guid StatusId { get; set; }
        public string Status { get; set; }
    }
}