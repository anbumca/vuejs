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
    public class EducatorTrackingActivity
    {
        [Key]
        [Column(TypeName = "bigint")]
        public long internal_id { get; set; }

        [Column(TypeName ="bigint")]
        //FK info not found
        public long educator_user_id { get; set; }

        [Column(TypeName ="bigint")]
        [ForeignKey("Tenant")]
        public long? tenant_id { get; set; }
        public virtual Tenant Tenant { get; set; }

        [Column(TypeName ="bigint")]
        [ForeignKey("Salon")]
        public long salon_id { get; set; }
        public virtual Salon Salon { get; set; }

        [Column(TypeName ="bigint")]
        [ForeignKey("SalonProfile")]
        public long? salon_profile_id { get; set; }
        public virtual SalonProfile SalonProfile { get; set; }

        [Column(TypeName ="bigint")]
        [ForeignKey("EducatorTrackingActivityType")]
        public long educator_tracking_activity_type { get; set; }
        public virtual EducatorTrackingActivityType EducatorTrackingActivityType { get; set; }

        [Column(TypeName ="bigint")]
        [ForeignKey("Brand")]
        public long brand_id { get; set; }
        public virtual Brand Brand { get; set; }

        [Column(TypeName ="nvarchar(50)")]
        public string content_unique_id { get; set; }

        [Column(TypeName ="bigint")]
        [ForeignKey("AssetPortfolio")]
        public long asset_portfolio_id { get; set; }
        public virtual AssetPortfolio AssetPortfolio { get; set; }

        public int? localization_type { get; set; }

        public int? audience_type { get; set; }

        public int? priority_level { get; set; }

        [Column(TypeName ="nvarchar(999)")]
        public string topic { get; set; }

        public DateTime? start_date { get; set; }

        public DateTime? end_date { get; set; }

        [Column(TypeName ="nvarchar(4000)")]
        public string educator_notes { get; set; }

        //other properties not available in the given CustomerServiceLayer_MCD.pdf file

        public virtual ICollection<EducatorTrackingActivityAttendees> EducatorTrackingActivityAttendees { get; set; }
    }
}
