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
    public class LMSCategoryAddField
    {
        [Key]
        [Column(TypeName = "bigint")]
        public long internal_id { get; set; }

        [Column(TypeName ="bigint")]
        //FK info not found
        public long? parent_id { get; set; }

        [Column(TypeName ="nvarchar(50)")]
        public string content_unique_id { get; set; }

        [Column(TypeName ="nvarchar(999)")]
        public string value { get; set; }

        [Column(TypeName ="bit")]
        public bool? is_root { get; set; }

        [Column(TypeName ="nvarchar(999)")]
        public string lms_additional_field_type { get; set; }

        [Column(TypeName ="nvarchar(999)")]
        public string lms_additional_field_value_id { get; set; }

        public virtual ICollection<LMSLearningCourseCategory> LMSLearningCourseCategory { get; set; }
    }
}
