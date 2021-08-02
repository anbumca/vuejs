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
    public class SalonProfilePortfolio
    {
        [Key]
        [Column(TypeName = "bigint")]
        public long internal_id { get; set; }

        [Column(TypeName ="bigint")]
        [ForeignKey("AssetPortfolio")]
        public long asset_portfolio_id { get; set; }
        public virtual AssetPortfolio AssetPortfolio { get; set; }

        [Column(TypeName ="bigint")]
        [ForeignKey("SalonProfile")]
        public long salon_profile_id { get; set; }
        public virtual SalonProfile SalonProfile { get; set; }

        public int display_order { get; set; }
    }
}
