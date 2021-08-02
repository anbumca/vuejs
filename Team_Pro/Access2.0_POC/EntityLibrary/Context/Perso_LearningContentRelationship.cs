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
    public class Perso_LearningContentRelationship
    {
        [Key]
        [Column(TypeName = "bigint")]
        public long internal_id { get; set; }

        [Column(TypeName = "bigint")]
        [ForeignKey("Tenant")]
        public long? tenant_id { get; set; }
        public virtual Tenant Tenant { get; set; }

        [Column(TypeName ="nvarchar(50)")]
        public string content_unique_id { get; set; }

        [Column(TypeName ="nvarchar(MAX)")]
        public string relationship_rate_result_json { get; set; }

        [Column(TypeName = "nvarchar(MAX)")]
        public string relationship_rate_result_csv { get; set; }
    }
}
