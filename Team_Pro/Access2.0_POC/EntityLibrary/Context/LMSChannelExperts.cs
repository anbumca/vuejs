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
    public class LMSChannelExperts
    {
        [Key]
        [Column(TypeName = "bigint")]
        public long internal_id { get; set; }

        [Column(TypeName = "bigint")]
        [ForeignKey("LMSChannel")]
        public long? lms_channel_id { get; set; }
        public virtual LMSChannel LMSChannel { get; set; }

        [Column(TypeName = "bigint")]
        [ForeignKey("User")]
        public long? user_id { get; set; }
        public virtual User User { get; set; }
    }
}
