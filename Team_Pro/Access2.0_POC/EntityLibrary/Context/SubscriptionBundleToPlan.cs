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
    public class SubscriptionBundleToPlan
    {
        [Key]
        [Column(TypeName = "bigint")]
        public long internal_id { get; set; }

        [Column(TypeName = "bigint")]
        [ForeignKey("SubscriptionBundle")]
        public long subscription_bundle_id { get; set; }
        public virtual SubscriptionBundle SubscriptionBundle { get; set; }

        [Column(TypeName = "bigint")]
        [ForeignKey("SubscriptionPlan")]
        public long subscription_plan_id { get; set; }
        public virtual SubscriptionPlan SubscriptionPlan { get; set; }
    }
}
