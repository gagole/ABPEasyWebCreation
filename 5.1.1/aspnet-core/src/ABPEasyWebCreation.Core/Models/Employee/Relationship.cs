using Abp.Domain.Entities.Auditing;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace ABPEasyWebCreation.Models.Employee
{
    public class Relationship : FullAuditedEntity
    {
        [Required]
        public RelationshipTypes RelationshipType { get; set; }
        [Required]
        public string FullName { get; set; }
        [Required]
        public System.Nullable<DateTime> DOB { get; set; }
        public string Remark { get; set; }

        public enum RelationshipTypes
        {
            Father = 1,
            Mother = 2,
            Husband = 3,
            Wife = 4,
            Son = 5,
            Daughter = 6
        }
    }
}
