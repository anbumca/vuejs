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
    public class Translations
    {
        [Key]
        [Column(TypeName = "bigint")]
        public long internal_id { get; set; }

        [Column(TypeName ="bigint")]
        [ForeignKey("ContentUniqueIdReferential")]
        public long? content_unique_id { get; set; }
        public virtual ContentUniqueIdReferential ContentUniqueIdReferential { get; set; }

        [Column(TypeName ="bigint")]
        [ForeignKey("Tenant")]
        public long? tenant_id { get; set; }
        public virtual Tenant Tenant { get; set; }

        [Column(TypeName ="nvarchar(5)")]
        //no direct FK because of 2 DBs architecture
        public string lang_code { get; set; }

        [Column(TypeName ="nvarchar(20)")]
        public string index_key { get; set; }

        [Column(TypeName ="nvarchar(MAX)")]
        public string value { get; set; }

        public DateTime? created_at { get; set; }

        public DateTime? lastupdate_at { get; set; }

        [Column(TypeName ="bigint")]
        //FK info not found
        public long? creator_user_id { get; set; }

        [Column(TypeName ="bigint")]
        //FK info not found
        public long? lastupdator_user_id { get; set; }
    }
}
