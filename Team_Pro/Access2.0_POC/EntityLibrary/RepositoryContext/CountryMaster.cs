using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;
using Microsoft.Data.SqlClient;
using System.Data;


/**
* @author udhayakumar_m
*
* @date - 7/20/2021 4:24:18 PM 
*/

namespace EntityLibrary.RepositoryContext
{
    public class CountryMaster
    {
        [Key]
        [Column(TypeName = "bigint")]
        public long internal_id { get; set; }

        [Column(TypeName = "nvarchar(50)")]
        public string CountryISOCode { get; set; }

        [Column(TypeName ="nvarchar(50)")]
        public string CountryName { get; set; }

        public bool? IsActive { get; set; }

        [Column(TypeName ="nvarchar(50)")]
        public string CreatedBy { get; set; }

        public DateTime? CreatedDate { get; set; }

        [Column(TypeName = "nvarchar(50)")]
        public string ModifiedBy { get; set; }

        public DateTime? ModifiedDate { get; set; }

        public virtual ICollection<Elements> Elements { get; set; }
    }
}
