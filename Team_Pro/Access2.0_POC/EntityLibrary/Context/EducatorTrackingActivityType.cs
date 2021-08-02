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
    public class EducatorTrackingActivityType
    {
        [Key]
        [Column(TypeName = "bigint")]
        public long internal_id { get; set; }

        [Column(TypeName ="bigint")]
        [ForeignKey("ParentEducatorTrackingActivityType")]
        public long? parent_id { get; set; }
        public virtual EducatorTrackingActivityType ParentEducatorTrackingActivityType { get; set; }
    
        [Column(TypeName ="nvarchar(50)")]
        public string content_unique_id { get; set; }

        [Column(TypeName ="nvarchar(999)")]
        public string internal_code { get; set; }

        [Column(TypeName ="nvarchar(255)")]
        public string default_label { get; set; }

        public virtual ICollection<EducatorTrackingActivity> EducatorTrackingActivity { get; set; }
        public virtual ICollection<EducatorTrackingActivityType> Children { get; set; }
    }
}
