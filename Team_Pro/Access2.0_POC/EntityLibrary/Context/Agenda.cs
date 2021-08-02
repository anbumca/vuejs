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
    public class Agenda
    {
        [Key]
        [Column(TypeName = "bigint")]
        public long internal_id { get; set; }

        [Column(TypeName ="bigint")]
        //FK info not found in the given document
        public long owner_user_id { get; set; }

        [Column(TypeName ="nvarchar(50)")]
        public string content_unique_id { get; set; }

        [Column(TypeName ="nvarchar(255)")]
        public string name { get; set; }

        [Column(TypeName ="nvarchar(4000)")]
        public string description { get; set; }

        [Column(TypeName ="nvarchar(50)")]
        public string related_content_unique_id { get; set; }

        [Column(TypeName = "bit")]
        public bool? is_public { get; set; }

        public DateTime? opening_time { get; set; }

        public DateTime? ending_time { get; set; }
    }
}
