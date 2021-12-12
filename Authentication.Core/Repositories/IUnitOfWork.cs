using System.Threading.Tasks;

namespace Authentication.Core.Repositories
{
    public interface IUnitOfWork
    {
        Task CompleteAsync();
    }
}
