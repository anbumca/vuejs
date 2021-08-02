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
    public class SalonProfile
    {
        [Key]
        [Column(TypeName = "bigint")]
        public long internal_id { get; set; }

        [Column(TypeName ="bigint")]
        [ForeignKey("Salone")]
        public long salon_id { get; set; }
        public virtual Salon Salone { get; set; }

        [Column(TypeName ="bigint")]
        //FK table info not found in the given document
        public long country_id { get; set; }

        [Column(TypeName ="bigint")]
        //FK table info not found in the given document
        public long? main_picture_asset_id { get; set; }

        [Column(TypeName ="nvarchar(1000)")]
        public string address { get; set; }

        [Column(TypeName ="nvarchar(1000)")]
        public string zip_code { get; set; }

        [Column(TypeName = "geography")]
        public string gps_coordinates { get; set; }

        [Column(TypeName ="nvarchar(MAX)")]
        public string telephone_numbers { get; set; }

        //other properties not available in the given CustomerServiceLayer_MCD.pdf file

        public virtual ICollection<SalonProfilePortfolio> SalonProfilePortfolio { get; set; }
        public virtual ICollection<EducatorTrackingActivity> EducatorTrackingActivity { get; set; }
    }
}
