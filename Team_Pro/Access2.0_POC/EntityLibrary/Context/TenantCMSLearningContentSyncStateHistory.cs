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
    public class TenantCMSLearningContentSyncStateHistory
    {
        [Key]
        [Column(TypeName = "bigint")]
        public long internal_id { get; set; }

        [Column(TypeName ="bigint")]
        [ForeignKey("TenantCMSLearningContentSyncState")]
        public long? tenant_cms_learning_content_sync_state_id { get; set; }
        public virtual TenantCMSLearningContentSyncState TenantCMSLearningContentSyncState { get; set; }

        public DateTime? created_at { get; set; }

        [Column(TypeName ="nvarchar(50)")]
        public string action_category { get; set; }

        [Column(TypeName ="nvarchar(MAX)")]
        public string action_description { get; set; }

        public string sync_cms_object_version { get; set; }

        public string sync_learning_object_version { get; set; }
    }
}
