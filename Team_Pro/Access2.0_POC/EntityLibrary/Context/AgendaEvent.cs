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
    public class AgendaEvent
    {
        [Key]
        [Column(TypeName = "bigint")]
        public long internal_id { get; set; }

        [Column(TypeName ="bigint")]
        //FK info not found
        public long creator_user_id { get; set; }

        [Column(TypeName = "bigint")]
        //FK info not found
        public long lastupdator_user_id { get; set; }

        [Column(TypeName ="nvarchar(50)")]
        public string content_unique_id { get; set; }

        [Column(TypeName ="nvarchar(50)")]
        public string creator_user_content_unique_id { get; set; }

        [Column(TypeName ="nvarchar(50)")]
        public string lastupdator_user_content_unique_id { get; set; }

        public DateTime? created_at { get; set; }

        public DateTime? lastupdated_at { get; set; }

        [Column(TypeName ="nvarchar(255)")]
        public string name { get; set; }

        [Column(TypeName ="nvarchar(4000)")]
        public string description { get; set; }

        [Column(TypeName ="bit")]
        public bool? all_days { get; set; }

        public DateTime? start_time { get; set; }

        public DateTime? end_time { get; set; }

        public virtual ICollection<AgendaEventAttendees> AgendaEventAttendees { get; set; }
        public virtual ICollection<AgendaEventLinkedItems> AgendaEventLinkedItems { get; set; }
    }
}
