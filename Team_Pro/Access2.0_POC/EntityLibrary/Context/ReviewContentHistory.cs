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
    public class ReviewContentHistory
    {
        [Key]
        [Column(TypeName = "bigint")]
        public long internal_id { get; set; }

        [Column(TypeName ="bigint")]
        [ForeignKey("ReviewContent")]
        public long? review_content_id { get; set; }
        public virtual ReviewContent ReviewContent { get; set; }

        [Column(TypeName ="bigint")]
        //FK info not found
        public long? actor_user_id { get; set; }

        public DateTime? action_date { get; set; }

        public int? action_type { get; set; }

        [Column(TypeName ="nvarchar(MAX)")]
        public string extended_info { get; set; }
    }
}
