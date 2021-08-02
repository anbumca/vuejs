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
    public class SubscriptionBundle
    {
        [Key]
        [Column(TypeName = "bigint")]
        public long internal_id { get; set; }

        [Column(TypeName = "bigint")]
        [ForeignKey("ExternalEcommSystem")]
        public long external_ecomm_system_id { get; set; }
        public virtual ExternalEcommSystem ExternalEcommSystem { get; set; }


        [Column(TypeName = "bigint")]
        [ForeignKey("SubscriptionBundleType")]
        public long subscription_bundle_type { get; set; }
        public virtual SubscriptionBundleType SubscriptionBundleType { get; set; }

        [Column(TypeName = "bigint")]
        public long? brand_to_tenant_id { get; set; }

        [Column(TypeName = "bit")]
        public bool? is_enabled { get; set; }

        [Column(TypeName = "nvarchar(50)")]
        public string content_unique_id { get; set; }

        [Column(TypeName = "nvarchar(50)")]
        public string internal_code { get; set; }

        [Column(TypeName = "nvarchar(255)")]
        public string default_display_name { get; set; }

        [Column(TypeName = "nvarchar(4000)")]
        public string defaut_description { get; set; }

        [Column(TypeName = "nvarchar(999)")]
        public string external_ecomm_record_id { get; set; }

        public virtual ICollection<SubscriptionRecord> SubscriptionRecord { get; set; }
        public virtual ICollection<SubscriptionBundleToPlan> SubscriptionBundleToPlan { get; set; }
        public virtual ICollection<SubscriptionBundleToLearningContent> SubscriptionBundleToLearningContent { get; set; }
    }
}
