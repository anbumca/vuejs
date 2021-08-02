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
    public class UserProfile
    {
        [Key]
        [Column(TypeName = "bigint")]
        public long internal_id { get; set; }

        [Column(TypeName ="bigint")]
        [ForeignKey("User")]
        public long user_id { get; set; }
        public virtual User User { get; set; }

        [Column(TypeName ="bigint")]
        //foreign key infor missing in the given document
        public long? avatar_asset_id { get; set; }

        [Column(TypeName ="nvarchar(100)")]
        public string slug_name { get; set; }

        [Column(TypeName ="bit")]
        public bool? authorized_reminder { get; set; }

        //other properties not available in the given CustomerServiceLayer_MCD.pdf file

        public virtual ICollection<UserProfileRemindMeStatus> UserProfileRemindMeStatus { get; set; }
        public virtual ICollection<UserProfileExperience> UserProfileExperience { get; set; }
        public virtual ICollection<UserProfileSocialMediaLinks> UserProfileSocialMediaLinks { get; set; }
        public virtual ICollection<UserProfilePortfolio> UserProfilePortfolio { get; set; }
        public virtual ICollection<UserBookmark> UserBookmark { get; set; }
    }
}
