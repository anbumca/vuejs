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
    public class LMSCatalogToLearningPlan
    {
        [Key]
        [Column(TypeName = "bigint")]
        public long internal_id { get; set; }

        [Column(TypeName ="bigint")]
        [ForeignKey("LMSCatalog")]
        public long lms_catalog_id { get; set; }
        public virtual LMSCatalog LMSCatalog { get; set; }

        [Column(TypeName ="bigint")]
        [ForeignKey("LMSLearningPlan")]
        public long lms_learning_plan_id { get; set; }
        public virtual LMSLearningPlan LMSLearningPlan { get; set; }

        //https://confluence.e-loreal.com/display/SIAC/Learning+Catalogue+to+Learning+Plan+-+Table+Description
    }
}
