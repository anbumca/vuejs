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
    public class LMSSessionExtendedInfo
    {
        [Key]
        [Column(TypeName = "bigint")]
        public long internal_id { get; set; }

        [Column(TypeName ="bigint")]
        [ForeignKey("UserAssignmentToLearningContent")]
        public long? user_assignment_to_learning_content { get; set; }
        public virtual UserAssignmentToLearningContent UserAssignmentToLearningContent { get; set; }

        [Column(TypeName ="bigint")]
        //FK info not found in the document
        public long? evaluator_id { get; set; }

        public int? assignment_activity_status { get; set; }

        public DateTime? attendance_date { get; set; }

        public DateTime? completion_date { get; set; }

        public int? evaluation_status { get; set; }

        public DateTime? evaluation_date { get; set; }

        public int? evaluation_score { get; set; }

        [Column(TypeName ="nvarchar(999)")]
        public string evaluation_comment { get; set; }
    }
}
