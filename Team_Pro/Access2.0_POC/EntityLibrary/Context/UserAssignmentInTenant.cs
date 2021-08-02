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
    public class UserAssignmentInTenant
    {
        [Key]
        [Column(TypeName = "bigint")]
        public long internal_id { get; set; }

        [Column(TypeName ="bigint")]
        [ForeignKey("User")]
        public long user_id { get; set; }
        public virtual User User { get; set; }

        [Column(TypeName = "bigint")]
        [ForeignKey("Tenant")]
        public long tenant_id { get; set; }
        public virtual Tenant Tenant { get; set; }

        [Column(TypeName = "datetime")]
        public DateTime? created_at { get; set; }

        [Column(TypeName = "datetime")]
        public DateTime? expiration { get; set; }

        public virtual ICollection<UserToBrand> UserToBrand { get; set; }
        public virtual ICollection<UserAssignmentInTenantWithRole> UserAssignmentInTenantWithRole { get; set; }
        //Commented as foreign key exception and not valida FK info found in the document
        //public virtual ICollection<ContentActivityNotification> ContentActivityNotification { get; set; }
        //public virtual ICollection<FollowingContent> FollowingContent { get; set; }
    }
}
