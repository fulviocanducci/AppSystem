using AppSystem.Data;
using AppSystem.Models;

namespace AppSystem.Repository
{
    public abstract class AbstractRepositoryCity : AbstractRepository<City>
    {
        public AbstractRepositoryCity(Database database) : base(database)
        {
        }
    }
}
