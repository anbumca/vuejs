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
    public class UserToLMSGroup
    {
        [Key]
        [Column(TypeName = "bigint")]
        public long internal_id { get; set; }

        [Column(TypeName ="bigint")]
        [ForeignKey("User")]
        public long? user_id { get; set; }
        public virtual User User { get; set; }

        [Column(TypeName ="bigint")]
        [ForeignKey("LMSGroup")]
        public long? group_id { get; set; }
        public virtual LMSGroup LMSGroup { get; set; }

        [Column(TypeName ="bigint")]
        public long? lms_ext_obj_id_user { get; set; }

        [Column(TypeName ="bigint")]
        public long? lms_ext_obj_id_group { get; set; }
    }
}
