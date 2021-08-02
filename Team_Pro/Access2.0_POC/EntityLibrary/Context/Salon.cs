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
    public class Salon
    {
        [Key]
        [Column(TypeName = "bigint")]
        public long internal_id { get; set; }

        [Column(TypeName ="bigint")]
        //FK table info not found in the given document
        public long? manual_creation_user_id { get; set; }

        [Column(TypeName = "bigint")]
        //FK table info not found in the given document
        public long? parent_salon_id { get; set; }

        [Column(TypeName = "bigint")]
        //FK table info not found in the given document
        public long? main_owner_user_id { get; set; }

        [Column(TypeName ="bigint")]
        [ForeignKey("Tenant")]
        public long tenant_id { get; set; }
        public virtual Tenant Tenant { get; set; }

        [Column(TypeName ="bigint")]
        [ForeignKey("SalonNature")]
        public long salon_nature_id { get; set; }
        public virtual SalonNature SalonNature { get; set; }

        [Column(TypeName ="bigint")]
        [ForeignKey("SalonType")]
        public long salon_type_id { get; set; }
        public virtual SalonType SalonType { get; set; }

        [Column(TypeName ="nvarchar(50)")]
        public string content_unique_id { get; set; }

        [Column(TypeName ="nvarchar(255)")]
        public string name { get; set; }

        public int creation_status { get; set; }

        [Column(TypeName ="bit")]
        public bool? is_enabled { get; set; }

        public int status { get; set; }

        [Column(TypeName ="nvarchar(999)")]
        public string external_referential_id { get; set; }

        [Column(TypeName ="nvarchar(100)")]
        public string item_source_system { get; set; }


        public virtual ICollection<SalonAffiliation> SalonAffiliation { get; set; }
        public virtual ICollection<EducatorTrackingActivity> EducatorTrackingActivity { get; set; }
    }
}
