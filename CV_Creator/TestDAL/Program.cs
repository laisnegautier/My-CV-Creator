using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using Domain;

namespace TestDAL
{
    class Program
    {
        static void Main(string[] args)
        {
            // Marche
            //IResumeRepository testResume;
            //testResume = new ResumeRepository();
            //List<Resume> Resumes = testResume.GetAll();
            
            //foreach (Resume r in Resumes)
            //    Console.WriteLine(r.Title);


            // Marche pas
            IContainerRepository testContainer;
            testContainer = new ContainerRepository();
            List<Container> Containers = testContainer.GetAll();

            Console.WriteLine(Containers.Count);
            foreach (Container c in Containers)
            {
                Console.WriteLine('c');
                Console.WriteLine(c.Name);
            }
            
        }
    }
}
