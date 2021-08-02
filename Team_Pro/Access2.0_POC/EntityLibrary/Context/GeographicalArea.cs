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
    public class GeographicalArea
    {
        [Key]
        [Column(TypeName = "bigint")]
        public long internal_id { get; set; }

        [ForeignKey("ParentGeographicalArea")]
        [Column(TypeName = "bigint")]
        public long? parent_item_id { get; set; }
        public virtual GeographicalArea ParentGeographicalArea { get; set; }

        [Column(TypeName = "nvarchar(50)")]
        public string content_unique_id { get; set; }

        [Column(TypeName = "nvarchar(MAX)")]
        public string default_display_label { get; set; }

        [Column(TypeName = "tinyint")]
        public byte item_type { get; set; }

        [Column(TypeName = "bit")]
        public bool is_enabled { get; set; }

        public virtual ICollection<GeographicalArea> Children { get; set; }
        public virtual ICollection<GeographicalAreaToTimeZone> GeographicalAreaToTimeZone { get; set; }
        public virtual ICollection<GeographicalAreaToTenant> GeographicalAreaToTenant { get; set; }
    }
}
