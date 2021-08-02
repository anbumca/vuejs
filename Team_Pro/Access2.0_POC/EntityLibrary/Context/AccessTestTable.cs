using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;


/**
* @author udhayakumar_m
*
* @date - 7/21/2021 2:19:33 PM 
*/

namespace EntityLibrary.Context
{
    public class AccessTestTable
    {
        [Key]
        [Column(TypeName = "bigint")]
        public long internal_id { get; set; }

        [Column(TypeName = "nvarchar(50)")]
        public string test_name { get; set; }
    }
}
