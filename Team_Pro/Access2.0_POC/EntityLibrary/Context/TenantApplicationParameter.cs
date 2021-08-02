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
    public class TenantApplicationParameter
    {
        [Key]
        [Column(TypeName = "bigint")]
        public long internal_id { get; set; }


        [Column(TypeName = "bigint")]
        [ForeignKey("Tenant")]
        public long tenant_id { get; set; }
        public virtual Tenant Tenant { get; set; }

        [Column(TypeName = "nvarchar(255)")]
        public string app_settings_key { get; set; }

        [Column(TypeName = "nvarchar(MAX)")]
        public string app_settings_value { get; set; }
    }
}
