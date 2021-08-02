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
    public class ITZone
    {
        [Key]
        [Column(TypeName = "bigint")]
        public long internal_id { get; set; }

        [Column(TypeName ="nvarchar(999)")]
        public string internal_code { get; set; }

        [Column(TypeName ="nvarchar(255)")]
        public string name { get; set; }

        public virtual ICollection<Tenant> Tenant { get; set; }
    }
}
