using System;
using System.Collections.Generic;

namespace SchoolManagement.DataAccess.Models
{
    public partial class PaymentMode
    {
        public PaymentMode()
        {
            Fee = new HashSet<Fee>();
        }

        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedDate { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }

        public virtual ICollection<Fee> Fee { get; set; }
    }
}
