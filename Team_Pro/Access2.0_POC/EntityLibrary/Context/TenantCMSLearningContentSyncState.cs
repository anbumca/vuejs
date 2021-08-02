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
    public class TenantCMSLearningContentSyncState
    {
        [Key]
        [Column(TypeName = "bigint")]
        public long internal_id { get; set; }

        [Column(TypeName = "bigint")]
        [ForeignKey("TenantCMSConfiguration")]
        public long? tenant_cms_configuration_id { get; set; }
        public virtual TenantCMSConfiguration TenantCMSConfiguration { get; set; }

        public int? lms_object_type { get; set; }

        [Column(TypeName ="bigint")]
        public long? lms_object_id { get; set; }

        [Column(TypeName ="nvarchar")]
        public string cms_object_id { get; set; }

        [Column(TypeName = "nvarchar")]
        public string cms_object_path { get; set; }

        [Column(TypeName ="nvarchar(50)")]
        public string object_content_unique_id { get; set; }

        public DateTime? lasttime_sync_to_cms { get; set; }

        public DateTime? lasttime_sync_from_lms { get; set; }

        public string lasttime_sync_learning_object_version { get; set; }

        public string lasttime_sync_cms_object_version { get; set; }

        //All needed information to be able to determinate incremental rules & 2 ways sync if needed

        public virtual ICollection<TenantCMSLearningContentSyncStateHistory> TenantCMSLearningContentSyncStateHistory { get; set; }
    }
}
