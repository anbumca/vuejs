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
    public class LMSChannel
    {
        [Key]
        [Column(TypeName = "bigint")]
        public long internal_id { get; set; }

        [Column(TypeName ="bigint")]
        //FK info not found
        public long? owner_user_id { get; set; }

        [Column(TypeName ="bigint")]
        public long? lms_ext_obj_id { get; set; }

        [Column(TypeName ="nvarchar(50)")]
        public string content_unique_id { get; set; }

        public string default_name { get; set; }

        public string default_description { get; set; }

        public int? lms_type_id { get; set; }

        public string lms_uuid { get; set; }

        public DateTime? lms_created_at { get; set; }

        [Column(TypeName ="bit")]
        public bool? lms_is_enabled { get; set; }

        public string lms_icon_json { get; set; }

        [Column(TypeName ="bit")]
        public bool? visible_for_everyone { get; set; }

        public string lms_upload_permissions { get; set; }


        public virtual ICollection<LMSAssetInLMSChannel> LMSAssetInLMSChannel { get; set; }
        public virtual ICollection<LMSChannelExperts> LMSChannelExperts { get; set; }
        public virtual ICollection<LMSChannelVisibility> LMSChannelVisibility { get; set; }
    }
}
