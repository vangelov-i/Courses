namespace StudentSystem.Data.Repositories
{
    using System;
    using System.Collections.Generic;
    using System.Data.Entity;
    using System.Linq;
    using System.Linq.Expressions;

    using StudentSystem.Data.Contracts;

    public class GenericRepository<T>  : 
        IGenericRepository<T> where T : class
    {
        private IStudentSystemDbContext cotnext;

        public GenericRepository()
            : this(new StudentSystemDbContext())
        {
        }

        public GenericRepository(IStudentSystemDbContext studentSystemDbContext)
        {
            this.cotnext = studentSystemDbContext;
        }

        public IQueryable<T> All()
        {
            return this.cotnext.Set<T>();
        }

        public IQueryable<T> Search(Expression<Func<T, bool>> conditions)
        {
            return this.All().AsQueryable().Where(conditions);
        }

        public void Add(T entity)
        {
            this.ChangeEntityState(entity, EntityState.Added);
        }

        public void Update(T entity)
        {
            this.ChangeEntityState(entity, EntityState.Modified);
        }

        public T Delete(T entity)
        {
            this.ChangeEntityState(entity, EntityState.Deleted);

            return entity;
        }

        public void Delete(Expression<Func<T, bool>> conditions)
        {
            var entitiesToDelete = this.Search(conditions);
            foreach (var entity in entitiesToDelete)
            {
                this.Delete(entity);
            }
        }

        public void Detach(T entity)
        {
            this.ChangeEntityState(entity, EntityState.Detached);
        }

        public void SaveChanges()
        {
            this.cotnext.SaveChanges();
        }

        private void ChangeEntityState(T entity, EntityState state)
        {
            this.cotnext.Set<T>().Attach(entity);
            this.cotnext.Entry(entity).State = state;
        }
    }
}