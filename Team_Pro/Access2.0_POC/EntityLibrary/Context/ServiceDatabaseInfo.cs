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
    public class ServiceDatabaseInfo
    {
        [Key]
        [Column(TypeName = "bigint")]
        public long internal_id { get; set; }

        [Column(TypeName ="nvarchar(255)")]
        public string display_name { get; set; }

        [Column(TypeName ="nvarchar(4000)")]
        public string db_connection_string { get; set; }

        public virtual ICollection<Tenant> Tenant { get; set; }
    }
}
