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

            Assert.IsTrue(monResume1.Title == "Mon_CV1");
            Assert.IsTrue(monResume2.Title == "Mon_CV2");
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
            
            Resume resumeFromDB = testResume.GetById(8);

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
            
            // On update une ligne deja existante
            testResume.Save(resumeToModif);

            Resume resumeModified = testResume.GetById(7);

            Assert.IsNotNull(resumeModified);
            Assert.IsTrue(resumeModified.Title == resumeToModif.Title);
        }

        /* Marche

    Console.WriteLine("-----------------------------------------------");

            IContainerRepository testContainer;
    testContainer = new ContainerRepository();
    List<Container> Containers = testContainer.GetAll();

    Console.WriteLine(Containers.Count);
            foreach (Container c in Containers)
            {
                Console.WriteLine(c.Name);
            }

Console.WriteLine("-----------------------------------------------");

            IParagraphRepository testParagraph;
testParagraph = new ParagraphRepository();
List<Paragraph> Paragraphs = testParagraph.GetAll();

Console.WriteLine(Paragraphs.Count);
            foreach (Paragraph p in Paragraphs)
            {
                Console.WriteLine(p.Content);
            }

            Console.WriteLine("test : " + testParagraph.GetById(3));
            */
    }
}