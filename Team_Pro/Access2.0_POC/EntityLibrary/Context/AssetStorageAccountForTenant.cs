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
    public class AssetStorageAccountForTenant
    {
        [Key]
        [Column(TypeName = "bigint")]
        public long internal_id { get; set; }

        [Column(TypeName ="bigint")]
        [ForeignKey("Tenant")]
        public long tenant_id { get; set; }
        public virtual Tenant Tenant { get; set; }

        [Column(TypeName ="bigint")]
        [ForeignKey("AssetStorageAccount")]
        public long asset_storage_id { get; set; }
        public virtual AssetStorageAccount AssetStorageAccount { get; set; }

        public virtual ICollection<AssetPortfolioTypeToStorageAccountForTenant> AssetPortfolioTypeToStorageAccountForTenant { get; set; }
    }
}
