using SC.Domain.Models.Base;

namespace SC.Repository.Interfaces
{
    public interface IRepository<T> where T : IEntity
    {
        T Add(T obj);
        T Update(T obj);
        T GetById(int id);
        bool Delete(T obj);
    }
}