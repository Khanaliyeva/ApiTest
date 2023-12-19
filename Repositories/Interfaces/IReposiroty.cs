using ApiIntro.Entities;
using System.Linq.Expressions;

namespace ApiIntro.Repositories.Interfaces
{
    public interface IReposiroty
    {
        Task<IEnumerable<Car>> GetAll(Expression<Func<Car, bool>>? expression=null, params string[] includes);
        Task<Car> GetById(int id);
        Task Create(Car car);
        void Update(Car car);
        void Delete(Car car);
        Task SaceChangesAsync();

    }
}
