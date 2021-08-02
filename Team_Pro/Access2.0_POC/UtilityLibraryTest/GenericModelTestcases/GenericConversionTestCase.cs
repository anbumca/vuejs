using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;
using Generic.Model.Helpers;
using Generic.Model;
using EntityLibrary.Context;

/**
* @author udhayakumar_m
*
* @date - 7/23/2021 6:43:03 PM 
*/

namespace UtilityLibraryTest.GenericModelTestcases
{
    [TestFixture]
    public class GenericConversionTestCase
    {
        //Generic method test
        private static JsonModel genObj = new JsonModel()
        {
            sections = new List<Sections>()
        };

        private static Sections scs = new Sections
        {
            elements = new List<Elements>()
        };

        List<Elements> elm = new List<Elements>()
            {
                new Elements()
                {
                    elementname = "user_name",
                    elementfieldvalue = "udhayakumar.m@photon.in"
                },
                new Elements()
                {
                    elementname = "firstname",
                    elementfieldvalue = "Udhayakumar"
                },
                new Elements()
                {
                    elementname = "lastname",
                    elementfieldvalue = "Mothilal"
                },
                new Elements()
                {
                    elementname = "email",
                    elementfieldvalue = "udhayakumar.m@photon.in"
                },
                new Elements()
                {
                    elementname = "created_at",
                    elementfieldvalue = DateTime.Now.ToString()
                },
                new Elements()
                {
                    elementname = "internal_id",
                    elementfieldvalue = "1"
                },
                new Elements()
                {
                    elementname = "is_global_admin",
                    elementfieldvalue = "true"
                }
            };


        [Test]
        [SetUp]
        public void SuccessCase()
        {
            scs.elements.AddRange(elm);

            genObj.sections.Add(scs);

            ConvertGeneric cvrt = new ConvertGeneric();
            var userObj = new User();
            userObj = (User)cvrt.GenerateModel(genObj.sections[0], userObj);

            Assert.IsNotNull(userObj);
        }

        [Test]
        [SetUp]
        public void NullReferenceCase()
        {
            elm[0].elementfieldvalue = "";

            scs.elements.AddRange(elm);

            genObj.sections.Add(scs);

            ConvertGeneric cvrt = new ConvertGeneric();
            var userObj = new User();

            Assert.Throws<NullReferenceException>(() => cvrt.GenerateModel(genObj.sections[0], userObj));
        }
    }
}
