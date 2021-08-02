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
    public class User
    {
        [Key]
        [Column(TypeName = "bigint")]
        public long internal_id { get; set; }

        [Column(TypeName ="bigint")]
        //FK info missing in the given document
        public long authentication_provider_id { get; set; }

        [Column(TypeName ="bigint")]
        [ForeignKey("ParentUser")]
        public long? manager_user_id { get; set; }
        public virtual User ParentUser { get; set; }

        [Column(TypeName ="bigint")]
        [ForeignKey("TimeZone")]
        public long? preferred_timezone_id { get; set; }
        public virtual TimeZone TimeZone { get; set; }

        [Column(TypeName = "nvarchar(5)")]
        public string preferred_language_code { get; set; }

        [Column(TypeName = "nvarchar(3)")]
        public string preferred_date_format { get; set; }

        [Column(TypeName = "nvarchar(255)")]
        public string content_unique_id { get; set; }

        [Column(TypeName ="bigint")]
        public long? lms_user_id { get; set; }

        [Column(TypeName = "nvarchar(255)")]
        public string user_name { get; set; }

        [Column(TypeName = "nvarchar(255)")]
        public string firstname { get; set; }

        [Column(TypeName = "nvarchar(255)")]
        public string lastname { get; set; }

        [Column(TypeName = "nvarchar(255)")]
        public string email { get; set; }

        [Column(TypeName = "nvarchar(50)")]
        public string lms_uuid { get; set; }

        [Column(TypeName = "datetime")]
        public DateTime? expiration { get; set; }

        [Column(TypeName ="tinyint")]
        public byte email_validation_status { get; set; }

        [Column(TypeName = "bit")]
        public bool? valid { get; set; }

        [Column(TypeName = "nvarchar(255)")]
        public string oa_user_id { get; set; }

        public int? creation_type { get; set; }

        [Column(TypeName = "datetime")]
        public DateTime? created_at { get; set; }

        [Column(TypeName = "datetime")]
        public DateTime? last_access_date { get; set; }

        [Column(TypeName = "bit")]
        public bool? is_global_admin { get; set; }

        public virtual ICollection<UserAssignmentInTenant> UserAssignmentInTenant { get; set; }
        public virtual ICollection<UserGlobalAssignmentRole> UserGlobalAssignmentRole { get; set; }
        public virtual ICollection<UserProfile> UserProfile { get; set; }
        public virtual ICollection<SalonAffiliation> SalonAffiliation { get; set; }
        public virtual ICollection<Asset> Asset { get; set; }
        public virtual ICollection<ContentActivityNotification> ContentActivityNotification { get; set; }
        public virtual ICollection<FollowingContent> FollowingContent { get; set; }
        public virtual ICollection<LikeContent> LikeContent { get; set; }
        public virtual ICollection<RatingContent> RatingContent { get; set; }
        public virtual ICollection<UserBookmark> UserBookmark { get; set; }
        public virtual ICollection<ActivityTracking> ActivityTracking { get; set; }
        public virtual ICollection<UserHashtagActivityRate> UserHashtagActivityRate { get; set; }
        public virtual ICollection<UserVsUserHashtagActivityRate> User1 { get; set; }
        public virtual ICollection<UserVsUserHashtagActivityRate> User2 { get; set; }
        public virtual ICollection<LMSChannelExperts> LMSChannelExperts { get; set; }
        public virtual ICollection<UserToLMSGroup> UserToLMSGroup { get; set; }
        public virtual ICollection<UserToLMSBranch> UserToLMSBranch { get; set; }
        public virtual ICollection<BusinessUserProfile> BusinessUserProfile { get; set; }
        public virtual ICollection<UserToLMSGamificationBadge> UserToLMSGamificationBadge { get; set; }
    }
}
