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
    public class UserAssignmentToLearningContent
    {
        [Key]
        [Column(TypeName = "bigint")]
        public long internal_id { get; set; }

        [Column(TypeName ="bigint")]
        [ForeignKey("Tenant")]
        public long? tenant_id { get; set; }
        public virtual Tenant Tenant { get; set; }

        [Column(TypeName ="bigint")]
        [ForeignKey("User")]
        public long? user_id { get; set; }
        public virtual User User { get; set; }

        [Column(TypeName ="bigint")]
        //FK info not found in the document
        public long? subscriber_user_id { get; set; }

        [Column(TypeName = "bigint")]
        //FK info not found in the document
        public long? unenrollment_user_id { get; set; }

        [Column(TypeName = "bigint")]
        //FK info not found in the document
        public long? lms_learning_plan_id { get; set; }

        [Column(TypeName ="nvarchar(999)")]
        public string lms_learning_plan_ext_obj_id { get; set; }

        [Column(TypeName = "bigint")]
        //FK info not found in the document
        public long? lms_learning_course_id { get; set; }

        [Column(TypeName ="nvarchar(999)")]
        public string lms_learning_course_ext_obj_id { get; set; }

        [Column(TypeName = "bigint")]
        //FK info not found in the document
        public long? lms_learning_session_id { get; set; }

        [Column(TypeName ="nvarchar(999)")]
        public string lms_learning_session_ext_obj_id { get; set; }

        [Column(TypeName = "bigint")]
        //FK info not found in the document
        public long? lms_learning_event_id { get; set; }

        [Column(TypeName ="nvarchar(999)")]
        public string lms_learning_event_ext_obj_id { get; set; }

        [Column(TypeName = "bigint")]
        //FK info not found in the document
        public long? subscription_record_id { get; set; }

        [Column(TypeName = "bigint")]
        //FK info not found in the document
        public long? assignment_role_type_id { get; set; }

        public int? target_assignment_object_type { get; set; }

        [Column(TypeName ="nvarchar(50)")]
        public string target_assignment_content_unique_id { get; set; }

        [Column(TypeName ="bit")]
        public bool? is_active { get; set; }

        public DateTime? enrollment_start_date { get; set; }

        public DateTime? enrollment_end_date { get; set; }

        public DateTime? unenrollment_last_date { get; set; }

        public int? targeted_lms_item_status { get; set; }

        public DateTime? created_at { get; set; }

        public DateTime? lastupdate_at { get; set; }

        [Column(TypeName ="nvarchar(MAX)")]
        public string extended_properties { get; set; }
    }
}
