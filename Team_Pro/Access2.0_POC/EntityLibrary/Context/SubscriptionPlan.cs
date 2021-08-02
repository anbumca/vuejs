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
    public class SubscriptionPlan
    {
        [Key]
        [Column(TypeName = "bigint")]
        public long internal_id { get; set; }

        [Column(TypeName = "bigint")]
        [ForeignKey("Currency")]
        public long currency_id { get; set; }
        public virtual Currency Currency { get; set; }

        [Column(TypeName = "nvarchar(50)")]
        public string internal_code { get; set; }

        [Column(TypeName = "nvarchar(255)")]
        public string default_display_name { get; set; }

        [Column(TypeName = "int")]
        public int price { get; set; }

        [Column(TypeName = "int")]
        public int seats_or_licences_count { get; set; }

        [Column(TypeName = "int")]
        public int duration_type { get; set; }

        [Column(TypeName = "int")]
        public int duration_validaty_period { get; set; }

        [Column(TypeName = "int")]
        public int renewal_type { get; set; }

        [Column(TypeName = "nvarchar(999)")]
        public string external_ecomm_record_id { get; set; }

        public virtual ICollection<SubscriptionBundleToPlan> SubscriptionBundleToPlan { get; set; }
    }
}
