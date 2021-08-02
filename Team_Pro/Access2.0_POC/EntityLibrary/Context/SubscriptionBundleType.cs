﻿/**
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
    public class SubscriptionBundleType
    {
        [Key]
        [Column(TypeName = "bigint")]
        public long internal_id { get; set; }

        [Column(TypeName = "nvarchar(50)")]
        public string content_unique_id { get; set; }

        [Column(TypeName = "nvarchar(50)")]
        public string internal_code { get; set; }

        [Column(TypeName = "nvarchar(255)")]
        public string default_display_name { get; set; }

        public virtual ICollection<SubscriptionBundle> SubscriptionBundles { get; set; }
    }
}
