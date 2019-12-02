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
    public class ParagraphRepositoryTests
    {
        [TestMethod()]
        public void GetByIdTest()
        {
            IElementRepository testParagraph;
            testParagraph = new ParagraphRepository();

            // Be aware of the downcast !
            Paragraph paragraph1 = (Paragraph)testParagraph.GetById(1);
            Paragraph paragraph3 = (Paragraph)testParagraph.GetById(3);

            Assert.IsTrue(paragraph1.Content == "paragraphCV1-Container11");
            Assert.IsTrue(paragraph3.Content == "paragraphCV2-Container23");
        }

        [TestMethod()]
        public void DeleteTest()
        {
            IElementRepository testParagraph;
            testParagraph = new ParagraphRepository();

            Paragraph paragraphToDelete = (Paragraph)testParagraph.GetById(2);

            testParagraph.Delete(paragraphToDelete);

            Paragraph paragraphToDeleteCheck = (Paragraph)testParagraph.GetById(2);

            Assert.IsNull(paragraphToDeleteCheck);
        }
    }
}
