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
    public class Brand
    {
        [Key]
        [Column(TypeName = "bigint")]
        public long internal_id { get; set; }

        [Column(TypeName = "nvarchar(50)")]
        public string internal_code { get; set; }

        [Column(TypeName = "nvarchar(50)")]
        public string content_unique_id { get; set; }

        [Column(TypeName = "nvarchar(255)")]
        public string display_name { get; set; }

        [Column(TypeName = "nvarchar(255)")]
        public string lms_value_in_add_field { get; set; }

        //other properties not available in the given CustomerServiceLayer_MCD.pdf file

        public virtual ICollection<BrandAssignmentToTenant> BrandAssignmentToTenant { get; set; }
        public virtual ICollection<UserToBrand> UserToBrand { get; set; }
        public virtual ICollection<EducatorTrackingActivity> EducatorTrackingActivity { get; set; }
        public virtual ICollection<LMSContentBrandRelationship> LMSContentBrandRelationship { get; set; }
    }
}
