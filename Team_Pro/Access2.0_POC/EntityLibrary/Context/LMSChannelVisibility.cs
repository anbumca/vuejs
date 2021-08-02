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
    public class LMSChannelVisibility
    {
        [Key]
        [Column(TypeName = "bigint")]
        public long internal_id { get; set; }

        [Column(TypeName = "bigint")]
        [ForeignKey("LMSChannel")]
        public long? lms_channel_id { get; set; }
        public virtual LMSChannel LMSChannel { get; set; }

        public int? securable_object_type { get; set; }

        [Column(TypeName = "bigint")]
        public long? securable_object_internal_id { get; set; }

        public int? lms_securable_object_id { get; set; }
    }
}
