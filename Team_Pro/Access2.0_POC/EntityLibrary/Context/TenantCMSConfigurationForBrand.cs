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
    public class TenantCMSConfigurationForBrand
    {
        [Key]
        [Column(TypeName = "bigint")]
        public long internal_id { get; set; }

        [Column(TypeName ="bigint")]
        [ForeignKey("TenantCMSConfiguration")]
        public long? tenant_cms_configuration_id { get; set; }
        public virtual TenantCMSConfiguration TenantCMSConfiguration { get; set; }

        [Column(TypeName ="bigint")]
        [ForeignKey("BrandAssignmentToTenant")]
        public long? brand_to_tenant_id { get; set; }
        public virtual BrandAssignmentToTenant BrandAssignmentToTenant { get; set; }

        //All needed fields to be able to establish mapping in target sitecore website and folder for the brand
    }
}
