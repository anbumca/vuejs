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
    public class AgendaEventAttendees
    {
        [Key]
        [Column(TypeName = "bigint")]
        public long internal_id { get; set; }

        [Column(TypeName ="bigint")]
        [ForeignKey("AgendaEvent")]
        public long agenda_event_id { get; set; }
        public virtual AgendaEvent AgendaEvent { get; set; }

        [Column(TypeName ="bigint")]
        //FK info not found
        public long attendee_user_id { get; set; }

        public int attendee_level { get; set; }

        public int invitation_answer_status { get; set; }

        [Column(TypeName ="bit")]
        public bool? notification_enabled { get; set; }

        public DateTime? last_notification_time { get; set; }
    }
}
