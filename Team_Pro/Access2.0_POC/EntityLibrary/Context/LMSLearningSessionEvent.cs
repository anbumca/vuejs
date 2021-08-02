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
    public class LMSLearningSessionEvent
    {
        [Key]
        [Column(TypeName = "bigint")]
        public long internal_id { get; set; }

        [Column(TypeName ="bigint")]
        [ForeignKey("LMSLearningSession")]
        public long? lms_learning_session_id { get; set; }
        public virtual LMSLearningSession LMSLearningSession { get; set; }

        [Column(TypeName ="bigint"), ForeignKey("LMSLocation")]
        public long? lms_location_id { get; set; }
        public virtual LMSLocation LMSLocation { get; set; }

        [Column(TypeName ="bigint"), ForeignKey("LMSClassroom")]
        public long? lms_classroom_id { get; set; }
        public virtual LMSClassroom LMSClassroom { get; set; }

        [Column(TypeName ="bigint")]
        public long? lms_ext_obj_id { get; set; }

        [Column(TypeName ="nvarchar(50)")]
        public string content_unique_id { get; set; }

        //A lot of other fields ... (from document)

        public virtual ICollection<LMSLearningSessionEventRecording> LMSLearningSessionEventRecording { get; set; }
    }
}
