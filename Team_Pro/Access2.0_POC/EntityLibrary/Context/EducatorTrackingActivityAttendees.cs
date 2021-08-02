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
    public class EducatorTrackingActivityAttendees
    {
        [Key]
        [Column(TypeName = "bigint")]
        public long internal_id { get; set; }

        [Column(TypeName ="bigint")]
        [ForeignKey("EducatorTrackingActivity")]
        public long educator_tracking_activity_id { get; set; }
        public virtual EducatorTrackingActivity EducatorTrackingActivity { get; set; }

        [Column(TypeName ="bigint")]
        //FK into not found
        public long? attendee_user_id { get; set; }

        [Column(TypeName ="bigint")]
        [ForeignKey("UserInvitationRequest")]
        public long? attendee_user_invitation_request_id { get; set; }
        public virtual UserInvitationRequest UserInvitationRequest { get; set; }

        [Column(TypeName ="bit")]
        public bool? is_waiting_invitation { get; set; }
    }
}
