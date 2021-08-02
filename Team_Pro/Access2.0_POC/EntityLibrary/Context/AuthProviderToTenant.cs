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
    public class AuthProviderToTenant
    {
        [Key]
        [Column(TypeName = "bigint")]
        public long internal_id { get; set; }

        [Column(TypeName ="bigint")]
        [ForeignKey("Tenant")]
        public long tenant_id { get; set; }
        public virtual Tenant Tenant { get; set; }

        [Column(TypeName ="bigint")]
        [ForeignKey("AuthProvider")]
        public long auth_provider_id { get; set; }
        public virtual AuthProvider AuthProvider { get; set; }

        [Column(TypeName = "datetime")]
        public DateTime? created_at { get; set; }

        [Column(TypeName = "datetime")]
        public DateTime? lastupdate_at { get; set; }

        [Column(TypeName = "nvarchar(MAX)")]
        public string additional_settings { get; set; }

        //other properties not available in the given CustomerServiceLayer_MCD.pdf file
    }
}
