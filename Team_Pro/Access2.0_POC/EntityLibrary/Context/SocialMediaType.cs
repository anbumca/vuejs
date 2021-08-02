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
    public class SocialMediaType
    {
        [Key]
        [Column(TypeName = "bigint")]
        public long internal_id { get; set; }

        [Column(TypeName ="nvarchar(20)")]
        public string internal_code { get; set; }

        [Column(TypeName = "nvarchar(255)")]
        public string name { get; set; }

        [Column(TypeName ="nvarchar(4000)")]
        public string icon_url { get; set; }

        [Column(TypeName ="nvarchar(200)")]
        public string icon_css_class { get; set; }
    }
}
