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
    public class LMSCatalog
    {
        [Key]
        [Column(TypeName = "bigint")]
        public long internal_id { get; set; }

        [Column(TypeName ="nvarchar(50)")]
        public string content_unique_id { get; set; }

        //https://confluence.e-loreal.com/display/SIAC/Learning+Catalogue+-+Table+Description


        public virtual ICollection<LMSCatalogToLearningPlan> LMSCatalogToLearningPlan { get; set; }
        public virtual ICollection<LMSCatalogToLearningCourse> LMSCatalogToLearningCourse { get; set; }
        public virtual ICollection<TenantToLMSCatalog> TenantToLMSCatalog { get; set; }
    }
}
