using System;
using System.Collections.Generic;
using System.Text;


/**
* @author udhayakumar_m
*
* @date - 7/22/2021 4:07:19 PM 
*/

namespace Generic.Model.Helpers
{
    public class JsonModel
    {
        public int pageid { get; set; }
        public string backgroundimage { get; set; }
        public int? tenantid { get; set; }
        public int? countryid { get; set; }
        public string countryname { get; set; }
        public int? languageid { get; set; }
        public string languagecode { get; set; }
        public List<Sections> sections { get; set; }
    }

    public class Sections
    {
        public int sectionid { get; set; }
        public int pageid { get; set; }
        public string sectionname { get; set; }
        public List<Elements> elements { get; set; }
    }


    public class Elements
    {
        public int elementid { get; set; }
        public int sectionid { get; set; }
        public string elementname { get; set; }
        public string elementfieldlabel { get; set; }
        public string elementfield { get; set; }
        public string elementfieldtype { get; set; }
        public string serverobjecttype { get; set; }
        public string elementvalidation { get; set; }
        public bool? isrequired { get; set; }
        public bool? isdisabled { get; set; }
        public string seotags { get; set; }
        public string elementfieldvalue { get; set; }
    }
}
