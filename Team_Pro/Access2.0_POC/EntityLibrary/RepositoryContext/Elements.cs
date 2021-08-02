using EntityLibrary.Context;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;


/**
* @author udhayakumar_m
*
* @date - 7/20/2021 7:14:37 PM 
*/

namespace EntityLibrary.RepositoryContext
{
    public class Elements
    {
        [Key]
        [Column(TypeName = "bigint")]
        public long internal_id { get; set; }

        [Column(TypeName ="nvarchar(255)")]
        public string element_name { get; set; }

        [Column(TypeName ="nvarchar(255)")]
        public string element_field_label { get; set; }

        [Column(TypeName ="nvarchar(255)")]
        public string element_field { get; set; }

        [Column(TypeName ="bigint")]
        [ForeignKey("ElementTypeMaster")]
        public long element_field_type_id { get; set; }
        public ElementTypeMaster ElementTypeMaster { get; set; }

        [Column(TypeName ="nvarchar(150)")]
        public string server_object_type { get; set; }

        [Column(TypeName ="nvarchar(999)")]
        public string element_validation { get; set; }

        [Column(TypeName ="bit")]
        public bool is_required { get; set; }

        [Column(TypeName = "bit")]
        public bool is_disabled { get; set; }

        [Column(TypeName = "nvarchar(999)")]
        public string seo_tags { get; set; }
        
        [Column(TypeName = "nvarchar(999)")]
        public string element_field_value { get; set; }

        [Column(TypeName = "bigint", Order =2)]
        [ForeignKey("FieldsRepository")]
        public long? field_id { get; set; }
        public virtual FieldsRepository FieldsRepository { get; set; }

        [Column(TypeName = "nvarchar(4000)")]
        public string validation_fields { get; set; }

        [Column(TypeName ="bigint")]
        [ForeignKey("SectionMaster")]
        public long section_id { get; set; }
        public virtual SectionMaster SectionMaster { get; set; }

        //[Key]
        [Column(TypeName = "bigint")]
        [ForeignKey("CountryMaster")]
        public long? country_id { get; set; }
        public virtual CountryMaster CountryMaster { get; set; }

        //[Key]
        [Column(TypeName ="bigint")]
        [ForeignKey("LanguageMaster")]
        public long language_id { get; set; }
        public virtual LanguageMaster LanguageMaster { get; set; }

    }
}
