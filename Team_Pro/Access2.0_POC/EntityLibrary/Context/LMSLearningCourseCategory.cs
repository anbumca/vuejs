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
    public class LMSLearningCourseCategory
    {
        [Key]
        [Column(TypeName = "bigint")]
        public long internal_id { get; set; }

        [Column(TypeName ="bigint")]
        [ForeignKey("LMSLearningCourse")]
        public long? lms_learning_course_id { get; set; }
        public virtual LMSLearningCourse LMSLearningCourse { get; set; }

        [Column(TypeName ="bigint")]
        [ForeignKey("LMSCategoryAddField")]
        public long? lms_category_add_field_id { get; set; }
        public virtual LMSCategoryAddField LMSCategoryAddField { get; set; }
    }
}
