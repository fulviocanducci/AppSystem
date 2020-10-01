using AppSystem.Data;
using AppSystem.Models;

namespace AppSystem.Repository
{
    public abstract class AbstractRepositoryUf : AbstractRepository<Uf>
    {
        public AbstractRepositoryUf(Database database) : base(database)
        {
        }
    }
}
