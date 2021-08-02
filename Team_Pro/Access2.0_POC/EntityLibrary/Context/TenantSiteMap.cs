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
    public class TenantSiteMap
    {
        [Key]
        [Column(TypeName = "bigint")]
        public long internal_id { get; set; }

        [Column(TypeName ="bigint")]
        [ForeignKey("Tenant")]
        public long tenant_id { get; set; }
        public virtual Tenant Tenant { get; set; }

        [Column(TypeName = "nvarchar(MAX)")]
        public string sitemap_content { get; set; }

        [Column(TypeName = "datetime")]
        public DateTime? last_calculation_time { get; set; }
    }
}
