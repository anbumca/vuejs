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
    public class UserToLMSGamificationBadge
    {
        [Key]
        [Column(TypeName = "bigint")]
        public long internal_id { get; set; }

        [Column(TypeName = "bigint")]
        [ForeignKey("User")]
        public long? user_id { get; set; }
        public virtual User User { get; set; }

        [Column(TypeName ="bigint")]
        [ForeignKey("LMSGamificationBadge")]
        public long? lms_gamification_badge_id { get; set; }
        public virtual LMSGamificationBadge LMSGamificationBadge { get; set; }

        [Column(TypeName ="nvarchar(50)")]
        public string content_unique_id { get; set; }

        public int? total_score { get; set; }

        public DateTime? issue_date { get; set; }

        public int? total_badge_count { get; set; }
    }
}
