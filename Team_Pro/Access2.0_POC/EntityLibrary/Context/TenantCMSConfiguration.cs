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
    public class TenantCMSConfiguration
    {
        [Key]
        [Column(TypeName = "bigint")]
        public long internal_id { get; set; }

        [Column(TypeName ="bigint")]
        [ForeignKey("Tenant")]
        public long tenant_id { get; set; }
        public virtual Tenant Tenant { get; set; }

        [Column(TypeName ="nvarchar(50)")]
        public string name { get; set; }

        [Column(TypeName ="nvarchar(999)")]
        public string cms_target_container_id { get; set; }

        [Column(TypeName = "nvarchar(MAX)")]
        public string extended_settings { get; set; }

        //other properties not available in the given CustomerServiceLayer_MCD.pdf file

        public virtual ICollection<TenantCMSConfigurationForBrand> TenantCMSConfigurationForBrand { get; set; }
        public virtual ICollection<TenantCMSTemplateMapping> TenantCMSTemplateMapping { get; set; }
        public virtual ICollection<TenantCMSLearningContentSyncState> TenantCMSLearningContentSyncState { get; set; }
    }
}
