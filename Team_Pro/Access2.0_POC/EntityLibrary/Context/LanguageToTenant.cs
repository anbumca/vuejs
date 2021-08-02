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
    public class LanguageToTenant
    {
        [Key]
        [Column(TypeName = "bigint")]
        public long internal_id { get; set; }

        [Column(TypeName ="bigint")]
        [ForeignKey("Language")]
        public long language_id { get; set; }
        public virtual Language Language { get; set; }

        [Column(TypeName ="bigint")]
        [ForeignKey("Tenant")]
        public long tenant_id { get; set; }
        public virtual Tenant Tenant { get; set; }

        [Column(TypeName ="bit")]
        public bool? is_default { get; set; }
    }
}
