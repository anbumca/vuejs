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
    public class LMSPartner
    {
        [Key]
        [Column(TypeName = "bigint")]
        public long internal_id { get; set; }

        [Column(TypeName ="bigint")]
        public long? lms_ext_obj_id { get; set; }

        [Column(TypeName ="nvarchar(999)")]
        public string referral_id { get; set; }

        [Column(TypeName = "nvarchar(999)")]
        public string code { get; set; }

        [Column(TypeName = "nvarchar(4000)")]
        public string name { get; set; }

        [Column(TypeName = "nvarchar(4000)")]
        public string description { get; set; }

        [Column(TypeName = "nvarchar(4000)")]
        public string logo { get; set; }

        [Column(TypeName = "nvarchar(4000)")]
        public string city { get; set; }

        [Column(TypeName = "nvarchar(5)")]
        public string country { get; set; }

        //remaining properties not added in the document

        public virtual ICollection<LMSLearningCourse> LMSLearningCourse { get; set; }
    }
}
