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
    public class LMSContentBrandRelationship
    {
        [Key]
        [Column(TypeName = "bigint")]
        public long internal_id { get; set; }

        [Column(TypeName ="bigint")]
        //FK info not found
        public long? learning_content_item_id { get; set; }

        [Column(TypeName ="bigint")]
        [ForeignKey("Brand")]
        public long? brand_id { get; set; }
        public virtual Brand Brand { get; set; }

        public int? learning_content_item_type { get; set; }
    }
}
