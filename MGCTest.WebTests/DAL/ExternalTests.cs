using Microsoft.VisualStudio.TestTools.UnitTesting;
using MGCTest.Web.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MGCTest.Web.DAL.Tests
{
    [TestClass()]
    public class ExternalTests
    {
        [TestMethod()]
        public void CallExtApiTest()
        {
            External ext = new External();

            //To the case the asset is to the currently 2 employees returned by the api
            Assert.AreEqual(2, ext.GetEmployees().ToList().Count);

            //To the case the asset valedate that the employee´s name with id 2 is Sebastian 
            Assert.AreEqual("Sebastian", ext.GetEmployee(2).ToList()[0].Name);

        }
    }
}