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
    public class LMSLearningCourse
    {
        [Key]
        [Column(TypeName = "bigint")]
        public long internal_id { get; set; }

        [Column(TypeName ="bigint")]
        //FK info not found
        public long? related_brand_id { get; set; }

        [Column(TypeName ="bigint")]
        public long? lms_ext_obj_id { get; set; }

        [Column(TypeName ="nvarchar(50)")]
        public string content_unique_id { get; set; }

        [Column(TypeName ="bigint")]
        //FK info not found
        public long? lms_main_learning_category_id { get; set; }

        [Column(TypeName ="bigint")]
        [ForeignKey("LMSPartner")]
        public long? lms_partner_id { get; set; }
        public virtual LMSPartner LMSPartner { get; set; }


        public virtual ICollection<LMSLearningPlanToLearningCourse> LMSLearningPlanToLearningCourse { get; set; }
        public virtual ICollection<LMSCatalogToLearningCourse> LMSCatalogToLearningCourse { get; set; }
        public virtual ICollection<LMSLearningCourseAdditionalFields> LMSLearningCourseAdditionalFields { get; set; }
        public virtual ICollection<LMSLearningSession> LMSLearningSession { get; set; }
        public virtual ICollection<LMSLearningCourseToWidget> LMSLearningCourseToWidget { get; set; }
        public virtual ICollection<LMSLearningCourseCategory> LMSLearningCourseCategory { get; set; }
    }
}
