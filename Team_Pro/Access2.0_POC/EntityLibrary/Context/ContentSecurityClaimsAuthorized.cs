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
    public class ContentSecurityClaimsAuthorized
    {
        [Key]
        [Column(TypeName = "bigint")]
        public long internal_id { get; set; }

        [Column(TypeName ="nvarchar(50)")]
        public string securized_content_unique_id { get; set; }

        public int? securized_content_entity_type { get; set; }

        //FK info not found
        [Column(TypeName ="bigint")]
        public long? securized_content_item_id { get; set; }

        public string claims_type { get; set; }

        public string claims_value { get; set; }

        [Column(TypeName ="bit")]
        public bool? is_explicit_deny { get; set; }

        public int? permission_level { get; set; }

        [Column(TypeName ="bit")]
        public bool? fixed_entry { get; set; }
    }
}
