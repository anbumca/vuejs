using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;


/**
* @author udhayakumar_m
*
* @date - 7/20/2021 4:46:39 PM 
*/

namespace EntityLibrary.RepositoryContext
{
    public class LanguageMaster
    {
        [Key]
        [Column(TypeName = "bigint")]
        public long internal_id { get; set; }

        [Column(TypeName = "nvarchar(50)")]
        public string LangauageISOCode { get; set; }

        [Column(TypeName = "nvarchar(50)")]
        public string LanguageName { get; set; }

        [Column(TypeName = "nvarchar(255)")]
        public string LangauageDesc { get; set; }

        public bool? IsActive { get; set; }

        [Column(TypeName = "nvarchar(50)")]
        public string CreatedBy { get; set; }

        public DateTime? CreatedDate { get; set; }

        [Column(TypeName = "nvarchar(50)")]
        public string ModifiedBy { get; set; }

        public DateTime? ModifiedDate { get; set; }

        public virtual ICollection<Elements> Elements { get; set; }
    }
}
