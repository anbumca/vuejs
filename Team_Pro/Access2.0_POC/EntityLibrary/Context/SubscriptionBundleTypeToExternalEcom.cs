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
    public class SubscriptionBundleTypeToExternalEcom
    {
        [Key]
        [Column(TypeName = "bigint")]
        public long internal_id { get; set; }

        [Column(TypeName = "nvarchar(MAX)")]
        public string external_ecomm_record_id { get; set; }

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


        [Column(TypeName = "bigint")]
        [ForeignKey("ExternalEcommSystem")]
        public long external_ecomm_system_id { get; set; }
        public virtual ExternalEcommSystem ExternalEcommSystem { get; set; }
    }
}
