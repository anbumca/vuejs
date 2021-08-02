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
    public class LMSLearningCourseAdditionalFields
    {
        [Key]
        [Column(TypeName = "bigint")]
        public long internal_id { get; set; }

        [Column(TypeName ="bigint")]
        [ForeignKey("LMSLearningCourse")]
        public long? related_learning_course_id { get; set; }
        public virtual LMSLearningCourse LMSLearningCourse { get; set; }

        public string field_key { get; set; }

        public string field_value { get; set; }

        //https://confluence.e-loreal.com/display/SIAC/Learning+Course+To+Additional+Fields+-+Table+Description
    }
}
