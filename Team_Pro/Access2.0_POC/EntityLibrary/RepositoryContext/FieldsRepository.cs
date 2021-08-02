using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;


/**
* @author udhayakumar_m
*
* @date - 7/21/2021 7:34:51 PM 
*/

namespace EntityLibrary.RepositoryContext
{
    public class FieldsRepository
    {
        [Key]
        [Column(TypeName = "bigint")]
        public long internal_id { get; set; }

        [Column(TypeName = "nvarchar(255)")]
        public string field_name { get; set; }

        [Column(TypeName = "bigint")]
        [ForeignKey("TablesRepository")]
        public long table_id { get; set; }
        public TablesRepository TablesRepository { get; set; }

        [Column(TypeName = "bit")]
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
