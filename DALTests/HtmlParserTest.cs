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
    public class HtmlParserTest
    {
        [TestMethod()]
        public void WriteHtmlDocument()
        {
            IResumeRepository testResume;
            testResume = new ResumeRepository();

            Resume resume = testResume.GetById(2);

            HtmlParser test = new HtmlParser(resume);
            bool success = test.ParseToHtml();

            Assert.IsTrue(success);
        }
    }
}