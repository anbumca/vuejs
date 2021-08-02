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
    public class TenantCMSTemplateMapping
    {
        [Key]
        [Column(TypeName = "bigint")]
        public long internal_id { get; set; }

        [Column(TypeName = "bigint")]
        [ForeignKey("TenantCMSConfiguration")]
        public long? tenant_cms_configuration_id { get; set; }
        public virtual TenantCMSConfiguration TenantCMSConfiguration { get; set; }

        public int? lms_object_type { get; set; }

        [Column(TypeName ="nvarchar(100)")]
        public string cms_template_id { get; set; }

        [Column(TypeName ="nvarchar(MAX)")]
        public string extended_settings { get; set; }
    }
}
