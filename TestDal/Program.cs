using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using Domain;

namespace TestDal
{
    class Program
    {
        static void Main(string[] args)
        {            
            // Marche
            IResumeRepository testResume;
            testResume = new ResumeRepository();
            List<Resume> Resumes = testResume.GetAll();

            foreach (Resume r in Resumes)
            {
                Console.WriteLine(r.Title);
                Console.WriteLine(r.Containers.Count());

                // Attention la faut ABSOLUMENT PARTIR DE 1 car r.Containers[0] = null : il n'y a pas d'index en 1 pour mysql
                for(int i = 1; i < r.Containers.Count; i++)
                    Console.WriteLine("Valeur name : " + r.Containers[i].Name);
            }

            Console.WriteLine("-----------------------------------------------");
            // Marche pas
            IContainerRepository testContainer;
            testContainer = new ContainerRepository();
            List<Container> Containers = testContainer.GetAll();

            Console.WriteLine(Containers.Count);
            foreach (Container c in Containers)
            {
                Console.WriteLine(c.Name);
            }
        }
    }
}
