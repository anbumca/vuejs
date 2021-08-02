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
    //need to review the entity
    public class ContentUniqueIdReferential
    {
        [Key]
        [Column(TypeName = "bigint")]
        public long internal_id { get; set; }

        public int? content_entity_type { get; set; }

        [Column(TypeName ="bigint")]
        //FK info not found
        public long? entity_item_id { get; set; }

        [Column(TypeName ="bigint")]
        public long? data_container_id { get; set; }

        [Column(TypeName ="nvarchar(50)")]
        public string content_unique_id_value { get; set; }

        [Column(TypeName ="nvarchar(999)")]
        public string front_end_access_data { get; set; }

        [Column(TypeName = "nvarchar(999)")]
        public string object_overview_value { get; set; }

        public virtual ICollection<Translations> Translations { get; set; }
    }
}
