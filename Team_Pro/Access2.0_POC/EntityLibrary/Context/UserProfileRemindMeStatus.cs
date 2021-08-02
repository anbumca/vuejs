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
    public class UserProfileRemindMeStatus
    {
        [Key]
        [Column(TypeName = "bigint")]
        public long internal_id { get; set; }

        [Column(TypeName = "bigint")]
        [ForeignKey("UserProfile")]
        public long user_profile_id { get; set; }
        public virtual UserProfile UserProfile { get; set; }

        [Column(TypeName ="nvarchar(50)")]
        public string user_content_unique_id { get; set; }

        [Column(TypeName = "nvarchar(50)")]
        public string related_content_unique_id { get; set; }

        [Column(TypeName ="datetime")]
        public DateTime? created_at { get; set; }

        [Column(TypeName ="datetime")]
        public DateTime? last_displayed_time { get; set; }

        [Column(TypeName ="bit")]
        public bool? is_disabled { get; set; }

        [Column(TypeName ="datetime")]
        public DateTime? next_expected_displayed_time { get; set; }
    }
}
