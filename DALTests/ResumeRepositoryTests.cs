﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
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

        /* Marche
        IResumeRepository testResume;
        testResume = new ResumeRepository();
        List<Resume> Resumes = testResume.GetAll();

            foreach (Resume r in Resumes)
            {
                Console.WriteLine(r.Title);
                Console.WriteLine(r.Containers.Count());

                for(int i = 0; i<r.Containers.Count; i++)
                    Console.WriteLine("Valeur name : " + r.Containers[i].Name);
            }

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