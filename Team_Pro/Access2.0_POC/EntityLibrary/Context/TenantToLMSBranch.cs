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
    public class TenantToLMSBranch
    {
        [Key]
        [Column(TypeName = "bigint")]
        public long internal_id { get; set; }

        [Column(TypeName = "bigint")]
        [ForeignKey("Tenant")]
        public long? tenant_id { get; set; }
        public virtual Tenant Tenant { get; set; }

        [Column(TypeName ="bigint")]
        [ForeignKey("LMSBranch")]
        public long? lms_branch_id { get; set; }
        public virtual LMSBranch LMSBranch { get; set; }

        [Column(TypeName ="bit")]
        public bool? include_children { get; set; }

        [Column(TypeName ="bit")]
        public bool? explicit_exclusion_from_parent { get; set; }
    }
}
