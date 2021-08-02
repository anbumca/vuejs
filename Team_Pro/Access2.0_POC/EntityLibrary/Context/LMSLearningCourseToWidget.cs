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
    public class LMSLearningCourseToWidget
    {
        [Key]
        [Column(TypeName = "bigint")]
        public long internal_id { get; set; }

        [Column(TypeName ="bigint")]
        [ForeignKey("LMSLearningCourse")]
        public long? related_learning_course_id { get; set; }
        public virtual LMSLearningCourse LMSLearningCourse { get; set; }

        [Column(TypeName ="bigint")]
        [ForeignKey("LMSLearningWidgetType")]
        public long? related_learning_widget_id { get; set; }
        public virtual LMSLearningWidgetType LMSLearningWidgetType { get; set; }

        [Column(TypeName ="bigint")]
        public long? lms_ext_obj_widget_id { get; set; }

        [Column(TypeName ="nvarchar(255)")]
        public string widget_title { get; set; }

        public int? widget_position { get; set; }

        public int? widget_columns_span { get; set; }

        [Column(TypeName ="nvarchar(MAX)")]
        public string widget_params_json { get; set; }
    }
}
