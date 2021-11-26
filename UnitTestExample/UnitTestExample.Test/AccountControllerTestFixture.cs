using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnitTestExample.Controllers;

namespace UnitTestExample.Test
{
    public class AccountControllerTestFixture
    {
        [Test]
        public void TestValidateEmail(string email,bool expectedResult)//két bemenő paraméter
        {
            //arrange
            var accountController = new AccountController();//references-add ref-projects, nem lehet oda vissza és kör körös hivatkozás


            //act
            var result =accountController.ValidateEmail(email);

            //assert eredmény megfelel-e annak amit elvártam
            Assert.AreEqual(result, expectedResult); 
        }
    }
}
