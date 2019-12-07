using Microsoft.VisualStudio.TestTools.UnitTesting;
using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain;

namespace DAL.Tests
{
    [TestClass()]
    public class ElementRepositoryTest
    {
        [TestMethod()]
        public void GetByIdTest()
        {
            IElementRepository testElement;
            testElement = new ElementRepository();
            IElement element1 = testElement.GetById(1);
            IElement element2 = testElement.GetById(2);
            IElement element20000 = testElement.GetById(20000);

            Assert.IsTrue(element1.Id == 1);
            Assert.IsTrue(element2.Id == 2);
            Assert.IsNull(element20000);
        }
    }
}
