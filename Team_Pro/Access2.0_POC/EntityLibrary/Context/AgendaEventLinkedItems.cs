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
    public class AgendaEventLinkedItems
    {
        [Key]
        [Column(TypeName = "bigint")]
        public long internal_id { get; set; }

        [Column(TypeName ="bigint")]
        [ForeignKey("AgendaEvent")]
        public long agenda_event_id { get; set; }
        public virtual AgendaEvent AgendaEvent { get; set; }

        [Column(TypeName ="bigint")]
        [ForeignKey("AgendaEventLinkItemType")]
        public long agenda_link_item_type { get; set; }
        public virtual AgendaEventLinkItemType AgendaEventLinkItemType { get; set; }

        [Column(TypeName ="nvarchar(50)")]
        public string related_content_unique_id { get; set; }
    }
}
