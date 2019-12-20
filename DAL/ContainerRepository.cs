using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Domain;

namespace DAL
{
    public class ContainerRepository : Repository, IContainerRepository
    {
        public List<Container> GetFavoriteOnes()
        {
            return Session.Query<Container>()
                .Where(x => x.Favorite == true)
                .ToList();
        }

        public void Delete(Container container)
        {
            Session.Delete(container);
            Session.Flush();
        }
    }
}
