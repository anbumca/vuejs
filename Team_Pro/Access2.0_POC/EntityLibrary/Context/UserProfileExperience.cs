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
    public class UserProfileExperience
    {
        [Key]
        [Column(TypeName = "bigint")]
        public long internal_id { get; set; }

        [Column(TypeName ="bigint")]
        [ForeignKey("UserProfile")]
        public long user_profile_id { get; set; }
        public virtual UserProfile UserProfile { get; set; }

        [Column(TypeName ="bigint")]
        //FK table not found in the given document
        public long? attached_salon_id { get; set; }

        [Column(TypeName ="nvarchar(255)")]
        public string job_title { get; set; }

        [Column(TypeName ="nvarchar(4000)")]
        public string description { get; set; }

        [Column(TypeName ="datetime")]
        public DateTime? start_date { get; set; }

        [Column(TypeName = "datetime")]
        public DateTime? end_date { get; set; }

        [Column(TypeName ="bit")]
        public bool? is_published { get; set; }
    }
}
