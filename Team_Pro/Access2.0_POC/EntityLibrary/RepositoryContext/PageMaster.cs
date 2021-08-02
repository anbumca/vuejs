using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;


/**
* @author udhayakumar_m
*
* @date - 7/20/2021 6:13:40 PM 
*/

namespace EntityLibrary.RepositoryContext
{
    public class PageMaster
    {
        [Key]
        [Column(TypeName = "bigint")]
        public long internal_id { get; set; }

        [Column(TypeName ="nvarchar(50)")]
        public string page_name { get; set; }

        [Column(TypeName ="nvarchar(255)")]
        public string page_description { get; set; }

        public string background_image { get; set; }

        //[Column(TypeName ="bigint")]
        //[ForeignKey("Tenant")]
        //public int? tenantid { get; set; }
        //public virtual Tenant Tenant { get; set; }

        //[Column(TypeName ="bigint")]
        //[ForeignKey("Country")]
        //public int countryid { get; set; }
        //public Country Country { get; set; }

        public bool? IsActive { get; set; }

        [Column(TypeName = "nvarchar(50)")]
        public string CreatedBy { get; set; }

        public DateTime? CreatedDate { get; set; }

        [Column(TypeName = "nvarchar(50)")]
        public string ModifiedBy { get; set; }

        public DateTime? ModifiedDate { get; set; }

        public virtual ICollection<SectionMaster> SectionMaster { get; set; }
    }
}
