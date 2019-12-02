using Microsoft.VisualStudio.TestTools.UnitTesting;
using DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using Domain;

namespace DAL.Tests
{
    [TestClass()]
    public class ResumeRepositoryTests
    {
        [TestMethod()]
        public void GetAllTest()
        {
            // Marche
            IResumeRepository testResume;
            testResume = new ResumeRepository();
            List<Resume> Resumes = testResume.GetAll();


            Assert.IsTrue(Resumes[0].Title == "Mon_CV1");
        }
    }
}