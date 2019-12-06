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
    public class ResumeRepositoryTests
    {
        [TestMethod()]
        public void GetAllTest()
        {
            IResumeRepository testResume;
            testResume = new ResumeRepository();
            List<Resume> Resumes = testResume.GetAll();

            Assert.IsTrue(Resumes[0].Title == "Mon_CV1");
            Assert.IsTrue(Resumes[1].Title == "Mon_CV2");
        }

        [TestMethod()]
        public void GetByIdTest()
        {
            IResumeRepository testResume;
            testResume = new ResumeRepository();
            Resume monResume1 = testResume.GetById(1);
            Resume monResume2 = testResume.GetById(2);
            Resume monResume20000 = testResume.GetById(20000);

            H1 h1 = (H1)monResume2.Containers[3].Elements[1];

            Assert.IsTrue(monResume1.Title == "Mon_CV1");
            Assert.IsTrue(monResume2.Title == "Mon_CV2");
            Assert.IsTrue(monResume2.Containers[3].Elements[1].Id == 5);
            Assert.IsTrue(h1.Content == "h1Cont7Pos1");
            Assert.IsTrue(h1.Bold == false);
            Assert.IsNull(monResume20000);
        }

        [TestMethod()]
        public void GetTheLastFiveTest()
        {
            IResumeRepository testResume;
            testResume = new ResumeRepository();

            List<Resume> Resumes = testResume.GetTheLastFive();

            Assert.AreEqual(Resumes.Count, 5);
            Assert.IsTrue(Resumes[0].Title == "essai");
            Assert.IsTrue(Resumes[1].Title == "test");
            Assert.IsTrue(Resumes[2].Title == "test");
            Assert.IsTrue(Resumes[3].Title == "bleubleu");
            Assert.IsTrue(Resumes[4].Title == "essai");
        }

        [TestMethod()]
        public void GetTheFavoriteOnesTest()
        {
            IResumeRepository testResume;
            testResume = new ResumeRepository();

            List<Resume> Resumes = testResume.GetTheFavoriteOnes();

            Assert.AreEqual(Resumes.Count, 2);
            Assert.IsTrue(Resumes[0].Title == "Mon_CV1");
            Assert.IsTrue(Resumes[1].Title == "Mon_CV2");
        }

        [TestMethod()]
        public void InsertTest()
        {
            Resume monResume = new Resume("essai");

            IResumeRepository testResume;
            testResume = new ResumeRepository();
            testResume.Save(monResume);
            
            Resume resumeFromDB = testResume.GetById(4);

            Assert.IsNotNull(resumeFromDB);
            Assert.IsTrue(resumeFromDB.Title == "essai");
        }

        [TestMethod()]
        public void UpdateTest()
        {
            IResumeRepository testResume;
            testResume = new ResumeRepository();

            Resume resumeToModif = testResume.GetById(7);
            resumeToModif.Title = "test";
            
            // Update an already existing resume
            testResume.Save(resumeToModif);

            Resume resumeModified = testResume.GetById(7);

            Assert.IsNotNull(resumeModified);
            Assert.IsTrue(resumeModified.Title == resumeToModif.Title);
        }

        [TestMethod()]
        public void DeleteTest()
        {
            IResumeRepository testResume;
            testResume = new ResumeRepository();
 
            Resume resumeToDelete = testResume.GetById(7);

            testResume.Delete(resumeToDelete);

            Resume resumeToDeleteCheck = testResume.GetById(7);

            Assert.IsNull(resumeToDeleteCheck);
        }

        /** 
         * TO DOOOOOOOO
         */
        [TestMethod()]
        public void DeleteInCascadeTest()
        {
            throw new System.NotImplementedException();
        }
    }
}