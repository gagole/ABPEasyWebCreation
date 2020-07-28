using Abp.Domain.Entities.Auditing;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace ABPEasyWebCreation.Models.Employee
{
    public class Employee:FullAuditedEntity
    {
        public Employee()
        {
            Relationships = new HashSet<Relationship>();
        }
        [Required]
        public string FullName { get; set; }
        [Required]
        public string Nick { get; set; }
        [Required]
        public string StaffNo { get; set; }
        public string StaffNo2 { get; set; }
        public System.Nullable<DateTime> StartingDate { get; set; }
        public System.Nullable<DateTime> StartingDate2 { get; set; }
        public System.Nullable<DateTime> ProbationEndDate { get; set; }
        public System.Nullable<DateTime> DOB { get; set; }
        public string POB { get; set; }
        public string HomePhone { get; set; }
        public string Mobile { get; set; }
        public string Skype { get; set; }
        public string Email { get; set; }
        public string Ext { get; set; }
        public string Remark { get; set; }

        public virtual ICollection<Relationship> Relationships { get; set; }
    }
}
