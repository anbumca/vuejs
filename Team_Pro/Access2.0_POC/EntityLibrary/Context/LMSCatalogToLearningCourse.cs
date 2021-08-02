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
    public class LMSCatalogToLearningCourse
    {
        [Key]
        [Column(TypeName = "bigint")]
        public long internal_id { get; set; }

        [Column(TypeName ="bigint")]
        [ForeignKey("LMSCatalog")]
        public long? lms_catalog_id { get; set; }
        public virtual LMSCatalog LMSCatalog { get; set; }

        [Column(TypeName ="bigint")]
        [ForeignKey("LMSLearningCourse")]
        public long? lms_learning_course_id { get; set; }
        public virtual LMSLearningCourse LMSLearningCourse { get; set; }
    }
}
