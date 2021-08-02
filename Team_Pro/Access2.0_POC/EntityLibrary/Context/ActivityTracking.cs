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
    public class ActivityTracking
    {
        [Key]
        [Column(TypeName = "bigint")]
        public long internal_id { get; set; }

        [Column(TypeName ="bigint")]
        [ForeignKey("User")]
        public long? user_id { get; set; }
        public virtual User User { get; set; }

        [Column(TypeName = "bigint")]
        [ForeignKey("Tenant")]
        public long? tenant_id { get; set; }
        public virtual Tenant Tenant { get; set; }

        [Column(TypeName ="nvarchar(50)")]
        public string content_unique_id { get; set; }

        [Column(TypeName ="nvarchar(999)")]
        public string related_hashtags_list { get; set; }

        [Column(TypeName = "nvarchar(999)")]
        public string action_type_key { get; set; }

        [Column(TypeName ="nvarchar(4000)")]
        public string origin_url { get; set; }

        public DateTime? moment { get; set; }
    }
}
