﻿using Ekidait.Core.Entities;
using System.Linq.Expressions;

namespace Ekidait.Service.Abstract
{
    public interface IService<T> where T : class, IEntity, new()
    {
        List<T> GetAll();
        List<T> GetAll(Expression<Func<T, bool>> expression);
        IQueryable<T> GetQueryable();
        T Get(Expression<Func<T, bool>> expression);
        T Find(int id);
        void Add(T entity);
        void Delete(T entity);
        int SaveChanges();
        // Asenkron metotlar
        Task<T> FindAsync(int id);
        Task<T> GetAsync(Expression<Func<T, bool>> expression);
        Task <List<T>> GetAllAsync();
        Task <List<T>> GetAllAsync(Expression<Func<T, bool>> expression);
        Task AddAsync(int entity);
       Task <int> SaveChangesAsync();
        void Update(AppUser user);
        Task AddAsync(AppUser appUser);
        Task AddAsync(Contact contact);
        void Update(Address model);
    }
}