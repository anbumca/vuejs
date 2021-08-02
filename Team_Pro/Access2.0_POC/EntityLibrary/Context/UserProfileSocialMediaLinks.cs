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
    public class UserProfileSocialMediaLinks
    {
        [Key]
        [Column(TypeName = "bigint")]
        public long internal_id { get; set; }

        [Column(TypeName = "bigint")]
        [ForeignKey("UserProfile")]
        public long user_profile_id { get; set; }
        public virtual UserProfile UserProfile { get; set; }

        [Column(TypeName ="bigint")]
        //FK table info not found in the given document
        public long? social_media_type_id { get; set; }

        [Column(TypeName ="nvarchar(4000)")]
        public string link_value { get; set; }

        [Column(TypeName ="bit")]
        public bool? is_visible { get; set; }

        [Column(TypeName ="int")]
        public int display_order { get; set; }

        [Column(TypeName ="datetime")]
        public DateTime? created_at { get; set; }
    }
}
