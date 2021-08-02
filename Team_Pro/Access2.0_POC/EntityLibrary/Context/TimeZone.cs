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
    public class TimeZone
    {
        [Key]
        [Column(TypeName = "bigint")]
        public long internal_id { get; set; }

        [Column(TypeName = "nvarchar(50)")]
        public string content_unique_id { get; set; }

        [Column(TypeName = "nvarchar(255)")]
        public string timezone_lms_name { get; set; }

        [Column(TypeName = "nvarchar(MAX)")]
        public string default_display_label { get; set; }

        [Column(TypeName = "nvarchar(255)")]
        public string timezone_ms_id { get; set; }

        public TimeSpan base_utc_offset { get; set; }
        public TimeSpan dst_utc_offset { get; set; }

        public virtual ICollection<GeographicalAreaToTimeZone> GeographicalAreaToTimeZone { get; set; }
        public virtual ICollection<User> User { get; set; }
    }
}
