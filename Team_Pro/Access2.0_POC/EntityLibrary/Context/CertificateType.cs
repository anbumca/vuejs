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
    public class CertificateType
    {
        [Key]
        [Column(TypeName = "bigint")]
        public long internal_id { get; set; }

        //Other stuffs needs to be added
    }
}
