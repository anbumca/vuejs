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
    public class SubscriptionBundleToLearningContent
    {
        [Key]
        [Column(TypeName = "bigint")]
        public long internal_id { get; set; }

        [Column(TypeName = "bigint")]
        [ForeignKey("SubscriptionBundle")]
        public long subscription_bundle_id { get; set; }
        public virtual SubscriptionBundle SubscriptionBundle { get; set; }

        [Column(TypeName = "bigint")]
        public long learning_content_id { get; set; }

        public int learning_content_type { get; set; }

        [Column(TypeName = "nvarchar(50)")]
        public string learning_content_unique_id { get; set; }
    }
}
