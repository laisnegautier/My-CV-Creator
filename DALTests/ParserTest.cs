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
    public class ParserTest
    {
        /// <summary>
        /// Test HTML for our user Sylvie
        /// </summary>
        [TestMethod()]
        public void WriteHtmlDocumentSylvie()
        {
            IResumeRepository testResume;
            testResume = new ResumeRepository();

            Resume resume = testResume.GetById(2);

            HtmlParser test = new HtmlParser(resume);
            bool success = test.ParseToHtml();

            Assert.IsTrue(success);
        }

        /// <summary>
        /// Test HTML for our user Julien
        /// </summary>
        [TestMethod()]
        public void WriteHtmlDocumentJulien()
        {
            IResumeRepository testResume;
            testResume = new ResumeRepository();

            Resume resume = testResume.GetById(1);

            HtmlParser test = new HtmlParser(resume);
            bool success = test.ParseToHtml();

            Assert.IsTrue(success);
        }

        /// <summary>
        /// Test PDF for our user Sylvie
        /// </summary>
        [TestMethod()]
        public void WritePdfDocumentSylvie()
        {
            IResumeRepository testResume;
            testResume = new ResumeRepository();

            Resume resume = testResume.GetById(2);

            PdfParser test = new PdfParser(resume);
            bool success = test.ParseToPdf();

            Assert.IsTrue(success);
        }

        /// <summary>
        /// Test PDF for our user Julien
        /// </summary>
        [TestMethod()]
        public void WritePdfDocumentJulien()
        {
            IResumeRepository testResume;
            testResume = new ResumeRepository();

            Resume resume = testResume.GetById(1);

            PdfParser test = new PdfParser(resume);
            bool success = test.ParseToPdf();

            Assert.IsTrue(success);
        }
    }
}