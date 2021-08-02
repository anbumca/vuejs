/**
* @author udhayakumar_m
* @ reference CustomServiceLayer_MCD.pdf
*/

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace EntityLibrary.Context
{
    public class UserToBrand
    {
        [Key]
        [Column(TypeName = "bigint")]
        public long internal_id { get; set; }

        [Column(TypeName ="bigint")]
        [ForeignKey("Brand")]
        public long brand_id { get; set; }
        public virtual Brand Brand { get; set; }

        [Column(TypeName ="bigint")]
        [ForeignKey("UserAssignmentInTenant")]
        public long user_assignment_tenant_id { get; set; }
        public virtual UserAssignmentInTenant UserAssignmentInTenant { get; set; }

        public virtual ICollection<UserToBrandWithRole> UserToBrandWithRole { get; set; }
    }
}
