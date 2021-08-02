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
    public class LMSLearningWidgetType
    {
        [Key]
        [Column(TypeName = "bigint")]
        public long internal_id { get; set; }

        [Column(TypeName ="nvarchar(100)")]
        public string widget_content_type { get; set; }

        [Column(TypeName ="nvarchar(50)")]
        public string internal_code { get; set; }

        [Column(TypeName = "nvarchar(50)")]
        public string content_unique_id { get; set; }

        //All other needed fields (...) as per document

        //https://confluence.e-loreal.com/display/SIAC/Learning+Widget+Type+-+Table+Description

        public virtual ICollection<LMSLearningCourseToWidget> LMSLearningCourseToWidget { get; set; }
    }
}
