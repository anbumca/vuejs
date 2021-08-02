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
    public class ReviewContentToTag
    {
        [Key]
        [Column(TypeName = "bigint")]
        public long internal_id { get; set; }

        [Column(TypeName ="bigint")]
        [ForeignKey("ReviewContent")]
        public long? review_content_item_id { get; set; }
        public virtual ReviewContent ReviewContent { get; set; }

        [Column(TypeName ="nvarchar(50)")]
        public string review_content_unique_id { get; set; }

        [Column(TypeName ="bigint")]
        [ForeignKey("ReviewTag")]
        public long? review_tag_id { get; set; }
        public virtual ReviewTag ReviewTag { get; set; }

        [Column(TypeName ="nvarchar(50)")]
        public string review_tag_content_unique_id { get; set; }
    }
}
