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
    public class Currency
    {
        [Key]
        [DatabaseGenerated(databaseGeneratedOption:0)]
        [Column(TypeName = "bigint")]
        public long internal_id { get; set; }

        [Column(TypeName = "nvarchar(50)")]
        public string internal_code { get; set; }

        [Column(TypeName = "nvarchar(255)")]
        public string default_display_name { get; set; }

        [Column(TypeName = "nvarchar(10)")]
        public string symbol { get; set; }

        public virtual ICollection<SubscriptionPlan> SubscriptionPlan { get; set; }
    }
}
