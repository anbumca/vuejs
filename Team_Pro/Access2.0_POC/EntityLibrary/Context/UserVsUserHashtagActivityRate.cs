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
    public class UserVsUserHashtagActivityRate
    {
        [Key]
        [Column(TypeName = "bigint")]
        public long internal_id { get; set; }

        [Column(TypeName = "bigint")]
        [ForeignKey("Tenant")]
        public long? tenant_id { get; set; }
        public virtual Tenant Tenant { get; set; }

        [Column(TypeName = "bigint", Order = 0)]
        public long? user1_id { get; set; }

        [Column(TypeName = "bigint", Order = 0)]
        public long? user2_id { get; set; }

        public double? diff_activity_rate_7days { get; set; }

        public double? diff_activity_rate_31days { get; set; }

        public double? diff_activity_rate_90days { get; set; }

        public double? diff_activity_rate_365days { get; set; }


        [ForeignKey("user1_id")]
        [InverseProperty("User1")]
        public virtual User User1 { get; set; }

        [ForeignKey("user2_id")]
        [InverseProperty("User2")]
        public virtual User User2 { get; set; }
    }
}
