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
    public class LMSMainLearningCategory
    {
        [Key]
        [Column(TypeName = "bigint")]
        public long internal_id { get; set; }

        [Column(TypeName ="nvarchar(50)")]
        public string content_unique_id { get; set; }

        [Column(TypeName ="nvarchar(999)")]
        public string name { get; set; }

        [Column(TypeName ="bigint")]
        public long? lms_ext_obj_id { get; set; }
    }
}
