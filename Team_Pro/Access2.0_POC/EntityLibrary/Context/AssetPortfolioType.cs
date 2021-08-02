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
    public class AssetPortfolioType
    {
        [Key]
        [Column(TypeName = "bigint")]
        public long internal_id { get; set; }

        [Column(TypeName ="nvarchar(20)")]
        public string internal_code { get; set; }

        [Column(TypeName ="nvarchar(255)")]
        public string default_label { get; set; }

        [Column(TypeName ="bit")]
        public bool? is_personal_portfolio { get; set; }

        public virtual ICollection<AssetPortfolioTypeToStorageAccountForTenant> AssetPortfolioTypeToStorageAccountForTenant { get; set; }
        public virtual ICollection<AssetPortfolio> AssetPortfolio { get; set; }
    }
}
