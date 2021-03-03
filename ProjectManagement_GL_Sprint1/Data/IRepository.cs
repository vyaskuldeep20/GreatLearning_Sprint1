using System.Collections.Generic;
using System.Threading.Tasks;

namespace ProjectManagement.Data
{
    public interface IRepository<T> where T : class 
        {
            Task<List<T>> GetAll();
            Task<T> Get(int id);
            Task<T> Add(T entity);
            Task<T> Update(T entity);
            Task<T> Delete(int id);
        }


    public interface IUserRepository<T> where T : class
    {
        Task<T> Get(string userName);
    }
}