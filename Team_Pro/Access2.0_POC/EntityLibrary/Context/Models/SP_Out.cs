using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;


/**
* @author udhayakumar_m
*
* @date - 7/20/2021 12:38:32 PM 
*/

namespace EntityLibrary.Context.Models
{
    [Keyless]
    public class SP_Out
    {
        public int? ErrorCode { get; set; }
        public string Message { get; set; }
        public int? OutputCode { get; set; }
    }
}
