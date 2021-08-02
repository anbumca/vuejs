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
    public class UserInvitationRequest
    {
        [Key]
        [Column(TypeName = "bigint")]
        public long internal_id { get; set; }

        [Column(TypeName ="bigint")]
        [ForeignKey("Tenant")]
        public long? tenant_id { get; set; }
        public virtual Tenant Tenant { get; set; }

        [Column(TypeName ="bigint")]
        //FK info not found
        public long? invitor_user_id { get; set; }

        [Column(TypeName ="bigint")]
        //FK info not found
        public long? result_invited_user_id { get; set; }

        [Column(TypeName ="nvarchar(999)")]
        public string invited_user_email { get; set; }

        public int? invitation_state { get; set; }

        public DateTime? invitation_date { get; set; }

        public int? invitation_mail_send_status { get; set; }

        public DateTime? last_invitation_mail_send { get; set; }

        [Column(TypeName ="nvarchar(4000)")]
        public string invitation_additional_message { get; set; }

        public virtual ICollection<EducatorTrackingActivityAttendees> EducatorTrackingActivityAttendees { get; set; }
    }
}
