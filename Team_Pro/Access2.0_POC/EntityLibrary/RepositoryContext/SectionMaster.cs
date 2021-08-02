using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;


/**
* @author udhayakumar_m
*
* @date - 7/20/2021 6:58:32 PM 
*/

namespace EntityLibrary.RepositoryContext
{
    public class SectionMaster
    {
        [Key]
        [Column(TypeName = "bigint")]
        public long internal_id { get; set; }

        [Column(TypeName ="nvarchar(255)")]
        public string section_name { get; set; }

        [Column(TypeName = "nvarchar(255)")]
        public string section_description { get; set; }

        [Column(TypeName ="bigint")]
        [ForeignKey("PageMaster")]
        public long page_id { get; set; }
        public virtual PageMaster PageMaster { get; set; }

        public bool? IsActive { get; set; }

        [Column(TypeName ="nvarchar(255)")]
        public string model_name { get; set; }

        [Column(TypeName = "nvarchar(50)")]
        public string CreatedBy { get; set; }

        public DateTime? CreatedDate { get; set; }

        [Column(TypeName = "nvarchar(50)")]
        public string ModifiedBy { get; set; }

        public DateTime? ModifiedDate { get; set; }

        public virtual ICollection<Elements> Elements { get; set; }
    }
}
