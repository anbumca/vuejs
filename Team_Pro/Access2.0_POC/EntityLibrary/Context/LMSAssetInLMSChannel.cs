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
    public class LMSAssetInLMSChannel
    {
        [Key]
        [Column(TypeName = "bigint")]
        public long internal_id { get; set; }

        [Column(TypeName ="bigint")]
        [ForeignKey("LMSChannel")]
        public long? lms_channel_id { get; set; }
        public virtual LMSChannel LMSChannel { get; set; }

        [Column(TypeName ="bigint")]
        [ForeignKey("LMSAsset")]
        public long? lms_asset_id { get; set; }
        public virtual LMSAsset LMSAsset { get; set; }

        [Column(TypeName ="bigint")]
        public long? lms_ext_obj_channel_id { get; set; }

        [Column(TypeName = "bigint")]
        public long? lms_ext_obj_asset_id { get; set; }
    }
}
