using System;
using System.Collections.Generic;
using System.Linq;
using AutoLotEntityDLL.EF;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Threading.Tasks;
using System.Data.Entity.Validation;

namespace AutoLotEntityDLL.Repository
{
    public abstract class BaseRepository<T> : IRepo<T> where T : class, new()
    {
        public AutoLotEntity context { get; } = new AutoLotEntity();
        protected DbSet<T> Table;

        public int Add(T entity)
        {
            try
            {
                Table.Add(entity);
                return Save();
            }
            catch (DbEntityValidationException validate) { throw validate; }
        }

        public int AddRange(List<T> entites)
        {
            try
            {
                Table.AddRange(entites);
                return Save();
            }
            catch (DbEntityValidationException validate) { throw validate; }
        }
        public int Delete(T entity)
        {
            context.Entry(entity).State = EntityState.Deleted;
            return Save();
        }
        public Task<int> DeleteAsync(T entity)
        {
            context.Entry(entity).State = EntityState.Deleted;
            return SaveAsync();
        }
        public int Save()
        {
            try
            {
                return context.SaveChanges();
            }
            catch (DbUpdateConcurrencyException dbUpdateConcurrency) { throw dbUpdateConcurrency; }
            catch (DbUpdateException dbUpdate) { throw dbUpdate; }
            catch (InvalidOperationException invalid) { throw invalid; }
        }
        public Task<int> SaveAsync()
        {
            try
            {
                return context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException dbUpdateConcurrency) { throw dbUpdateConcurrency; }
            catch (DbUpdateException dbUpdate) { throw dbUpdate; }
            catch (InvalidOperationException invalid) { throw invalid; }
        }

        public List<T> GetAll() => Table.ToList();
        

        public T Get(int? id)
        {
            return Table.Find(id ?? 0);
        }

        public int Update(T entity)
        {
            try
            {
                context.Entry(entity).State = EntityState.Modified;
            return Save(); }
            catch (DbUpdateConcurrencyException dbUpdateConcurrency) { throw dbUpdateConcurrency; }
            catch (DbUpdateException dbUpdate) { throw dbUpdate; }
            catch (InvalidOperationException invalid) { throw invalid; }
        }
        public Task<int> UpdateAsync(T entity)
        {
            try
            {
                context.Entry(entity).State = EntityState.Modified;
                return SaveAsync();
            }
            catch (DbUpdateConcurrencyException dbUpdateConcurrency) { throw dbUpdateConcurrency; }
            catch (DbUpdateException dbUpdate) { throw dbUpdate; }
            catch (InvalidOperationException invalid) { throw invalid; }
        }
        public Task<int> AddAsync(T entity)
        {
            try
            {
                Table.Add(entity);
                return context.SaveChangesAsync();
            }
            catch(DbEntityValidationException validate) { throw validate; }
            catch(DbUpdateException dbUpdate) { throw dbUpdate; }   
        }
        public Task<int> AddRangeAsync(List<T> entity)
        {
            try
            {
                Table.AddRange(entity);
                return context.SaveChangesAsync();
            }
            catch (DbEntityValidationException validate) { throw validate; }
            catch (DbUpdateException dbUpdate) { throw dbUpdate.InnerException; }
        }
       
        public Task<T> GetAsync(int? id)
        {
            try
            {
                return Table.FindAsync(id ?? 0);
            }
            catch(Exception e) { throw e.InnerException; }
        }
        public Task<List<T>> GetAllAsync()
        {
            try
            {
                return Table.ToListAsync();
            }
            catch(Exception e) { throw; }
        }
    }
}