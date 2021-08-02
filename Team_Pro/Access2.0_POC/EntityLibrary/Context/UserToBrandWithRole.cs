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
    public class UserToBrandWithRole
    {
        [Key]
        [Column(TypeName = "bigint")]
        public long internal_id { get; set; }

        [Column(TypeName ="bigint")]
        [ForeignKey("UserToBrand")]
        public long user_to_brand_id { get; set; }
        public virtual UserToBrand UserToBrand { get; set; }

        [Column(TypeName ="bigint")]
        [ForeignKey("UserRole")]
        public long user_role_id { get; set; }
        public virtual UserRole UserRole { get; set; }
    }
}
