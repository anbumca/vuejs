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
    public class FollowingContent
    {
        [Key]
        [Column(TypeName = "bigint")]
        public long internal_id { get; set; }

        [Column(TypeName ="nvarchar(50)")]
        public string related_content_unique_id { get; set; }

        [Column(TypeName = "bigint")]
        //Commented as foreign key exception and not valida FK info found in the document
        //[ForeignKey("User")]
        public long user_id { get; set; }
        //public User User { get; set; }

        [Column(TypeName = "bigint")]
        [ForeignKey("UserAssignmentInTenant")]
        public long user_to_tenant_id { get; set; }
        public virtual UserAssignmentInTenant UserAssignmentInTenant { get; set; }

        public DateTime? following_date { get; set; }

        [Column(TypeName ="bigint")]
        [ForeignKey("ContentActivityNotification")]
        public long? last_view_last_content_activity_notification_id { get; set; }
        public virtual ContentActivityNotification ContentActivityNotification { get; set; }
    }
}
