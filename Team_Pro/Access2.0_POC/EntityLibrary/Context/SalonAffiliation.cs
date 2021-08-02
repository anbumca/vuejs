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
    public class SalonAffiliation
    {
        [Key]
        [Column(TypeName = "bigint")]
        public long internal_id { get; set; }

        [Column(TypeName ="bigint")]
        [ForeignKey("User")]
        public long? user_id { get; set; }
        public virtual User User { get; set; }

        [Column(TypeName ="bigint")]
        [ForeignKey("Salon")]
        public long? salon_id { get; set; }
        public virtual Salon Salon { get; set; }

        [Column(TypeName ="bigint")]
        //FK table info not found in the given document
        public long? created_by { get; set; }

        [Column(TypeName = "bigint")]
        //FK table info not found in the given document
        public long? lastupdate_by { get; set; }

        [Column(TypeName ="bigint")]
        [ForeignKey("SalonAffiliationType")]
        public long? salon_affiliation_type_id { get; set; }
        public virtual SalonAffiliationType SalonAffiliationType { get; set; }

        public int? affiliation_validation_state { get; set; }

        public DateTime? validated_at { get; set; }

        public DateTime? created_at { get; set; }

        public DateTime? expiration_date { get; set; }

        public DateTime? lastupdate_at { get; set; }
    }
}
