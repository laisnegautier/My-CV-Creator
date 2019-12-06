using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Domain;
using DAL;

namespace StubRepository
{
    public class ResumeRepository : IResumeRepository
    {
        public Resume Copy(Resume resume)
        {
            throw new NotImplementedException();
        }

        public void Create(Resume resume)
        {
            throw new NotImplementedException();
        }

        public void Delete(Resume resume)
        {
            throw new NotImplementedException();
        }

        public List<Resume> GetAll()
        {
            Element elTest1 = new Paragraph();
            Element elTest2 = new Paragraph();
            List<Element> elem1 = new List<Element>();
            List<Element> elem2 = new List<Element>();
            elem1.Add(elTest1); elem2.Add(elTest1); elem2.Add(elTest2);
            Container container1 = new Container();

            container1.Elements = elem1;
            container1.Elements.Add(elTest1);
            Container container2 = new Container();
            container2.Elements = elem1;
            List<Container> cont1 = new List<Container>() { container1, container2 };
            List<Container> cont2 = new List<Container>() { container1, container1, container1 };
            List<Resume> result = new List<Resume>();
            Resume test = new Resume("CVtest1");
            Resume test2 = new Resume("CVtest2");
            test.Containers = cont2;
            test2.Containers = cont1;
            result.Add(test);
            result.Add(test);
            result.Add(test2);
            result.Add(test);
            result.Add(test);
            result.Add(test2);
            result.Add(test);
            result.Add(test);
            result.Add(test);
            result.Add(test2);
            result.Add(test);
            result.Add(test2);
            result.Add(test2);
            return result;
        }

        public void Save(Resume resume)
        {
            throw new NotImplementedException();
        }
    }
}
