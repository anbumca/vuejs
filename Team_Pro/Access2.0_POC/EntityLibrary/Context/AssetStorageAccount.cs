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
    public class AssetStorageAccount
    {
        [Key]
        [Column(TypeName = "bigint")]
        public long internal_id { get; set; }

        [Column(TypeName ="nvarchar(50)")]
        public string internal_code { get; set; }

        [Column(TypeName ="tinyint")]
        public byte storage_type { get; set; }

        [Column(TypeName ="bit")]
        public bool? anonymously_accessible { get; set; }

        [Column(TypeName ="nvarchar(MAX)")]
        public string settings { get; set; }

        public virtual ICollection<AssetStorageAccountForTenant> AssetStorageAccountForTenant { get; set; }
        public virtual ICollection<Asset> Asset { get; set; }
    }
}
