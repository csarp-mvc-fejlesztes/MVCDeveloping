using Microsoft.VisualStudio.TestTools.UnitTesting;
using Forma1.validation;
using Forma1.myexeption;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Forma1.validation.Tests
{
    [TestClass()]
    public class NameValidatorTests
    {
        [TestMethod()]
        public void validationTestNameEmty()
        {
            try
            {
                NameValidator nv = new NameValidator("");
                nv.validation();
                Assert.Fail("Üres névre nem dob kivételt!");
            }
            catch (NameNotValidNameIsEmptyException nnv)
            {
                if (nnv.Message != "A név nem lehet üres!")
                    Assert.Fail("Üres név esetén kivételt dob, de a kivétel szövege rossz!");
            }
            catch (Exception e)
            {
                Assert.Fail("Üres név esetén nem dob kivételt vagy rossz kivételt dob!");
            }
        }
        [TestMethod()]
        public void validationTestNameNotBeginWithUpperCase()
        {
            try
            {
                NameValidator nv = new NameValidator("nemecsek");
                nv.validation();
                Assert.Fail("Kis betűvel kezdődő név esetén nem dob kivételt!");
            }
            catch (NameNotValidFirstLetterProblemException nnv)
            {
                if (nnv.Message != "A név nagy kezdőbetűvel kell kezdőjön!")
                    Assert.Fail("Kis betűvel kezdődő név esetén kivételt dob, de a kivétel szövege rossz!");
            }
            catch (Exception e)
            {
                Assert.Fail("Kis betűvel kezdődő név esetén nem dob kivételt vagy rossz kivételt dob!");
                return;
            }                    
        }
        [TestMethod()]
        public void validationTestNameValid()
        {
            NameValidator nv = new NameValidator("Nemecsek");
            try
            {
                nv.validation();
            }
            catch (Exception e)
            {
                Assert.Fail("Nem üres és nagybetűvel kezdődő névre kivételt dob!");
            }
        }
    }
}