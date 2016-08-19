namespace StudentSystem.Data.Contracts
{
    using System;
    using System.Linq;
    using System.Linq.Expressions;

    public interface IGenericRepository<T> where T : class
    {
        void Add(T entity);

        IQueryable<T> All();

        IQueryable<T> Search(Expression<Func<T, bool>> conditions); 

        T Delete(T entity);

        void Delete(Expression<Func<T, bool>> conditions);

        void Update(T entity);

        void Detach(T entity);

        void SaveChanges();
    }
}