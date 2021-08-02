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
    public class ContentActivityNotification
    {
        [Key]
        [Column(TypeName = "bigint")]
        public long internal_id { get; set; }

        [Column(TypeName ="nvarchar(50)")]
        public string related_content_unique_id { get; set; }

        public int? action_type { get; set; }

        public int? notification_type { get; set; }

        [Column(TypeName ="bigint")]
        [ForeignKey("User")]
        public long user_id { get; set; }
        public virtual User User { get; set; }

        [Column(TypeName ="bigint")]
        //Commented as foreign key exception and not valida FK info found in the document
        //[ForeignKey("UserAssignmentInTenant")]
        public int user_to_tenant_id { get; set; }
        //public UserAssignmentInTenant UserAssignmentInTenant { get; set; }

        [Column(TypeName ="nvarchar(4000)")]
        public string displayed_additionnal_info { get; set; }

        public virtual ICollection<FollowingContent> FollowingContent { get; set; }
    }
}
