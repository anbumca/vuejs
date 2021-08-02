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
    public class ExternalEcommSystem
    {
        //[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key]
        [Column(TypeName = "bigint")]
        public long internal_id { get; set; }

        [Column(TypeName = "nvarchar(50)")]
        public string name { get; set; }

        [Column(TypeName = "nvarchar(50)")]
        public string internal_code { get; set; }

        [Column(TypeName = "nvarchar(MAX)")]
        public string settings { get; set; }

        [Column(TypeName = "varchar(150)")]
        public string CreatedBy { get; set; }

        [Column(TypeName = "DateTime")]
        public DateTime? CreatedOn { get; set; }

        [Column(TypeName = "varchar(150)")]
        public string ModifiedBy { get; set; }

        [Column(TypeName = "DateTime")]
        public DateTime? ModifiedOn { get; set; }

        public virtual ICollection<SubscriptionBundleTypeToExternalEcom> SubscriptionBundleTypeToExternalEcommSystems { get; set; }
        public virtual ICollection<SubscriptionBundle> subscriptionBundles { get; set; }
        public virtual ICollection<Tenant> Tenant { get; set; }
    }
}
