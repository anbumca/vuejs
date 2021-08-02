/**
* @author udhayakumar_m
* @ reference CustomServiceLayer_MCD.pdf
*/

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

using tct= System.Text;

namespace EntityLibrary.Context
{
    public class LMSLearningSessionEventRecording
    {
        [Key]
        [Column(TypeName = "bigint")]
        public long internal_id { get; set; }

        [Column(TypeName ="bigint"), ForeignKey("LMSLearningSessionEvent")]
        public long? lms_learning_session_event_id { get; set; }
        public virtual LMSLearningSessionEvent LMSLearningSessionEvent { get; set; }

        [Column(TypeName ="nvarchar(999)")]
        public string recording_type { get; set; }

        [Column(TypeName ="nvarchar(4000)")]
        public string recording_asset_url { get; set; }

        [Column(TypeName ="nvarchar(999)")]
        public string recording_asset_hls { get; set; }
    }
}
