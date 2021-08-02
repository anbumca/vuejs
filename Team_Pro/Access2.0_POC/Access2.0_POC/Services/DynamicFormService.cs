using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Access2._0_POC.Models;
using Access2._0_POC.Services.IServices;
//using ContextDynamic = EntityLibrary.Context.Dynamic;
using EntityLibrary.Context;

namespace Access2._0_POC.Services
{
    public class DynamicFormService : IDynamicForm
    {
        private AccessDbContext _context;

        public DynamicFormService(AccessDbContext Context)
        {
            _context = Context;
        }

        public DynamicForm GetDynamic(int pageid, int countryid, int tenantid, int languageid)
        {
            try
            {
                var formObj = new DynamicForm
                {
                    pageid = pageid,
                    backgroundimage = null,
                    tenantid = tenantid,
                    countryid = countryid,
                    countryname = "England",
                    languageid = 1,
                    languagecode = "ENG",
                    sections = new List<Sections>()
                    {
                        new Sections
                        {
                            sectionid=1,
                            pageid=pageid,
                            sectionname="LoginSection",
                            elements=new List<Elements>()
                            {
                                    new Elements()
                                    {
                                        elementid=1,
                                        sectionid=1,
                                        elementname = "LoginSection_E1",
                                        elementfieldlabel="Username",
                                        elementfieldtype="InputText",
                                        serverobjecttype="string",
                                        isrequired=true,
                                        isdisabled=false,
                                        elementfieldvalue = ""
                                    },
                                    new Elements()
                                    {
                                        elementid=2,
                                        sectionid=1,
                                        elementname = "LoginSection_E2",
                                        elementfieldlabel="Password",
                                        elementfieldtype="InputPassword",
                                        serverobjecttype="string",
                                        isrequired=true,
                                        isdisabled=false,
                                        elementfieldvalue = ""
                                    },
                                    new Elements()
                                    {
                                        elementid=3,
                                        sectionid=1,
                                        elementname = "LoginSection_E3",
                                        elementfieldlabel=null,
                                        elementfieldtype="SubmitButton",
                                        serverobjecttype="string",
                                        isrequired=true,
                                        isdisabled=false,
                                        elementfieldvalue = "Log in"
                                    }
                            }
                        }
                    }
                };

                return formObj;
            }
            catch (Exception e)
            {
                return null;
            }
        }
    }
}
