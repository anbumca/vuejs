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
    public class AssetPortfolioTypeToStorageAccountForTenant
    {
        [Key]
        [Column(TypeName = "bigint")]
        public long internal_id { get; set; }

        [Column(TypeName ="bigint")]
        [ForeignKey("AssetPortfolioType")]
        public long asset_portfolio_type_id { get; set; }
        public virtual AssetPortfolioType AssetPortfolioType { get; set; }

        [Column(TypeName ="bigint")]
        [ForeignKey("AssetStorageAccountForTenant")]
        public long asset_storage_for_tenant_id { get; set; }
        public virtual AssetStorageAccountForTenant AssetStorageAccountForTenant { get; set; }
    }
}
