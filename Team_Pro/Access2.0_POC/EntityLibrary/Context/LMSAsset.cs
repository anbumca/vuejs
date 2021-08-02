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
    public class LMSAsset
    {
        [Key]
        [Column(TypeName = "bigint")]
        public long internal_id { get; set; }

        [Column(TypeName ="bigint")]
        //FK info not found
        public long? contributor_user_id { get; set; }

        [Column(TypeName ="bigint")]
        public long? lms_ext_obj_id { get; set; }

        [Column(TypeName ="nvarchar(999)")]
        public string name { get; set; }

        [Column(TypeName = "nvarchar(999)")]
        public string asset_type { get; set; }

        [Column(TypeName ="bit")]
        public bool? is_published { get; set; }

        [Column(TypeName = "bit")]
        public bool? is_private { get; set; }

        public int? channels_assignment_count { get; set; }

        public int? people_assignment_count { get; set; }

        public  DateTime? created_at { get; set; }

        public virtual ICollection<LMSAssetInLMSChannel> LMSAssetInLMSChannel { get; set; }
    }
}
