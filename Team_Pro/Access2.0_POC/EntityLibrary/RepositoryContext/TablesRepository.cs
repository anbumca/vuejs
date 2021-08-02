using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;


/**
* @author udhayakumar_m
*
* @date - 7/21/2021 7:34:42 PM 
*/

namespace EntityLibrary.RepositoryContext
{
    public class TablesRepository
    {
        [Key]
        [Column(TypeName = "bigint")]
        public long internal_id { get; set; }

        [Column(TypeName ="nvarchar(255)")]
        public string database_name { get; set; }

        [Column(TypeName ="nvarchar(255)")]
        public string table_name { get; set; }

        [Column(TypeName ="bit")]
        public bool? IsActive { get; set; }

        [Column(TypeName = "nvarchar(50)")]
        public string CreatedBy { get; set; }

        public DateTime? CreatedDate { get; set; }

        [Column(TypeName = "nvarchar(50)")]
        public string ModifiedBy { get; set; }

        public DateTime? ModifiedDate { get; set; }

        public virtual ICollection<FieldsRepository> FieldsRepository { get; set; }
    }
}
