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
    public class UserBookmark
    {
        [Key]
        [Column(TypeName = "bigint")]
        public long internal_id { get; set; }

        [Column(TypeName = "bigint")]
        [ForeignKey("Tenant")]
        public long? tenant_id { get; set; }
        public virtual Tenant Tenant { get; set; }

        [Column(TypeName ="bigint")]
        [ForeignKey("User")]
        public long? user_id { get; set; }
        public virtual User User { get; set; }

        [Column(TypeName ="bigint")]
        [ForeignKey("UserProfile")]
        public long? user_profile_id { get; set; }
        public virtual UserProfile UserProfile { get; set; }

        [Column(TypeName ="bigint")]
        public long? bookmarked_content_unique_id { get; set; }

        public DateTime? created_at { get; set; }

        [Column(TypeName ="nvarchar(999)")]
        public string bookmark_category { get; set; }
    }
}
