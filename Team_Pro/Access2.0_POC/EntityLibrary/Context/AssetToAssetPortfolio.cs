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
    public class AssetToAssetPortfolio
    {
        [Key]
        [Column(TypeName = "bigint")]
        public long internal_id { get; set; }

        [Column(TypeName ="bigint")]
        //FK information not matching
        public long user_portfolio_id { get; set; }

        [Column(TypeName ="bigint")]
        [ForeignKey("Asset")]
        public long asset_id { get; set; }
        public virtual Asset Asset { get; set; }

        public DateTime? inserted_at { get; set; }

        public int? display_order { get; set; }

        [Column(TypeName ="bit")]
        public bool? is_published { get; set; }

        //other properties not available in the given CustomerServiceLayer_MCD.pdf file
    }
}
