using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Domain;

namespace DAL
{
    public class ContainerRepository : Repository, IContainerRepository
    {
        public List<Container> GetAll()
        {
            return Session.Query<Container>().ToList();
        }
        public Container GetById(int id)
        {
            return Session.Get<Container>(id);
        }
    }
}
