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
    public class Asset
    {
        [Key]
        [Column(TypeName = "bigint")]
        public long internal_id { get; set; }

        [Column(TypeName ="bigint")]
        [ForeignKey("AssetStorageAccount")]
        public long asset_storage_id { get; set; }
        public virtual AssetStorageAccount AssetStorageAccount { get; set; }

        [Column(TypeName ="bigint")]
        [ForeignKey("User")]
        public long owner_user_id { get; set; }
        public virtual User User { get; set; }

        [Column(TypeName ="nvarchar(255)")]
        public string content_unique_id { get; set; }

        [Column(TypeName = "nvarchar(255)")]
        public string file_name { get; set; }

        public DateTime? created_at { get; set; }

        [Column(TypeName ="bit")]
        public bool? is_personal_asset { get; set; }

        [Column(TypeName ="bit")]
        public bool? is_blacklisted { get; set; }

        public DateTime? last_access_time { get; set; }

        [Column(TypeName ="nvarchar(4000)")]
        public string public_url { get; set; }

        public DateTime? expiration_date { get; set; }

        //other properties not available in the given CustomerServiceLayer_MCD.pdf file

        public virtual ICollection<AssetToAssetPortfolio> AssetToAssetPortfolio { get; set; }
    }
}
