using ApiIntro.DAL;
using ApiIntro.Entities;
using ApiIntro.Repositories.Interfaces;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace ApiIntro.Repositories.Implimentations
{
    public class Repository : IReposiroty
    {
        private readonly AppDbContext _context;

        public Repository(AppDbContext context)
        {
            _context = context;
        }


        public async Task<IQueryable<Car>> GetAll(Expression<Func<Car,bool>>? expression, params string[] includes)
        {
            IQueryable<Car> query =  _context.cars;
            if(includes is not null)
            {
                for(int i= 0; i < includes.Length; i++)
                {
                    query=query.Include(includes[i]);
                }
            }
            if(expression is not null)
            {
                query = query.Where(expression);
            }
            return query;
        }

        public async Task<Car> GetById(int id)
        {
            return await _context.cars.AsNoTracking().FirstOrDefaultAsync(c => c.Id == id);
        }

        public void Update(Car car)
        {
            _context.cars.Update(car);
        }


        public async Task Create(Car car)
        {
            await _context.cars.AddAsync(car);
          
        }

        public void Delete(Car car)
        {
            _context.cars.Remove(car);
        }

        Task<IEnumerable<Car>> IReposiroty.GetAll(Expression<Func<Car, bool>>? expression, params string[] includes)
        {
            throw new NotImplementedException();
        }

        public async Task SaceChangesAsync()
        {
            await _context.SaveChangesAsync();
        }
    }
}
