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
    public class AssetPortfolio
    {
        [Key]
        [Column(TypeName = "bigint")]
        public long internal_id { get; set; }

        [Column(TypeName ="bigint")]
        //FK conflict found
        public long owner_user_id { get; set; }

        [Column(TypeName ="bigint")]
        [ForeignKey("AssetPortfolioType")]
        public long asset_portfolio_type_id { get; set; }
        public virtual AssetPortfolioType AssetPortfolioType { get; set; }

        [Column(TypeName ="nvarchar(50)")]
        public string content_unique_id { get; set; }

        [Column(TypeName ="nvarchar(255)")]
        public string name { get; set; }

        [Column(TypeName ="nvarchar(4000)")]
        public string description { get; set; }

        public DateTime? created_at { get; set; }

        public DateTime? lastupdate_at { get; set; }

        [Column(TypeName ="bit")]
        public bool? is_published { get; set; }

        public virtual ICollection<SalonProfilePortfolio> SalonProfilePortfolio { get; set; }
        public virtual ICollection<UserProfilePortfolio> UserProfilePortfolio { get; set; }
        public virtual ICollection<EducatorTrackingActivity> EducatorTrackingActivity { get; set; }
    }
}
