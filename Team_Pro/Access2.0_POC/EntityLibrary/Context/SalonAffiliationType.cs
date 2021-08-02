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
    public class SalonAffiliationType
    {
        [Key]
        [Column(TypeName = "bigint")]
        public long internal_id { get; set; }

        [Column(TypeName ="nvarchar(255)")]
        public string default_name { get; set; }

        [Column(TypeName ="nvarchar(50)")]
        public string content_unique_id { get; set; }

        [Column(TypeName ="nvarchar(999)")]
        public string internal_code { get; set; }

        [Column(TypeName ="nvarchar(4000)")]
        public string icon_url { get; set; }

        [Column(TypeName = "nvarchar(999)")]
        public string icon_class { get; set; }

        [Column(TypeName ="bigint")]
        public long? associated_permission_mask { get; set; }


        public virtual ICollection<SalonAffiliation> SalonAffiliation { get; set; }
    }
}
