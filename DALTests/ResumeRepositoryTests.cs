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
            Resume monResume3 = testResume.GetById(3);

            Assert.IsTrue(monResume1.Title == "Mon_CV1");
            Assert.IsTrue(monResume2.Title == "Mon_CV2");
            Assert.IsNull(monResume3);
        }

        [TestMethod()]
        public void SaveTest()
        {
            Resume monResume = new Resume("essai");
            //monResume.Id = 3;
            monResume.Save = true;
            monResume.LastModification = "now";
            monResume.Favorite = false;

            IResumeRepository testResume;
            testResume = new ResumeRepository();
            testResume.Save(monResume);
            
            Resume resumeFromDB = testResume.GetById(3);

            Assert.IsNotNull(resumeFromDB);
            Assert.IsTrue(resumeFromDB.Title == "essai");
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