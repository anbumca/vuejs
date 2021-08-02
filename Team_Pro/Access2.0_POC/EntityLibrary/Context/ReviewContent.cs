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
    public class ReviewContent
    {
        [Key]
        [Column(TypeName = "bigint")]
        public long internal_id { get; set; }

        [Column(TypeName ="nvarchar(50)")]
        public string content_unique_id { get; set; }

        [Column(TypeName ="nvarchar(50)")]
        public string related_content_unique_id { get; set; }

        [Column(TypeName ="bigint")]
        //FK info not found
        public long? author_id { get; set; }

        [Column(TypeName ="bigint")]
        [ForeignKey("Tenant")]
        public long? tenant_id { get; set; }
        public virtual Tenant Tenant { get; set; }

        [Column(TypeName ="bigint")]
        //FK info not found
        public long? last_updator_user_id { get; set; }

        [Column(TypeName ="bigint")]
        public long? parent_review_id { get; set; }

        public DateTime? created_at { get; set; }

        public int? moderation_status { get; set; }

        [Column(TypeName ="nvarchar(4000)")]
        public string review_content { get; set; }

        public virtual ICollection<ReviewContentToTag> ReviewContentToTag { get; set; }
        public virtual ICollection<ReviewContentHistory> ReviewContentHistory { get; set; }
    }
}
