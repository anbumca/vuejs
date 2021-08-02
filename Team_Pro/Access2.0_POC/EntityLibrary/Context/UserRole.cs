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
    public class UserRole
    {
        [Key]
        [Column(TypeName = "bigint")]
        public long internal_id { get; set; }

        [Column(TypeName = "nvarchar(50)")]
        public string internal_code { get; set; }

        [Column(TypeName = "nvarchar(20)")]
        public string claims_value_suffix_for_role { get; set; }

        [Column(TypeName = "nvarchar(255)")]
        public string role_label { get; set; }

        [Column(TypeName = "bit")]
        public bool? is_role_brand_related { get; set; }

        [Column(TypeName = "bit")]
        public bool? is_role_tenant_related { get; set; }

        [Column(TypeName = "bit")]
        public bool? is_role_global { get; set; }

        [Column(TypeName = "int")]
        public int? permission_level_mask { get; set; }

        public virtual ICollection<UserGlobalAssignmentRole> UserGlobalAssignmentRole { get; set; }
        public virtual ICollection<UserAssignmentInTenantWithRole> UserAssignmentInTenantWithRole { get; set; }
        public virtual ICollection<UserToBrandWithRole> UserToBrandWithRole { get; set; }
    }
}
