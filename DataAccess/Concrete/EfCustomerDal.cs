﻿using DataAccess.Abstract;
using DataAccess.Concrete.EntityFramework;
using Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace DataAccess.Concrete
{
    public class EfCustomerDal : ICustomerDal
    {
        public void Add(Customer entity)
        {
            using (NorthwindContext context = new())
            {
                var addedEntity = context.Entry(entity);
                addedEntity.State = EntityState.Added;
                context.SaveChanges();
            }
        }

        public void Delete(Customer entity)
        {
            using (NorthwindContext context = new())
            {
                var deletedEntity = context.Remove(entity);
                deletedEntity.State = EntityState.Deleted;
                context.SaveChanges();
            }
        }

        public List<Customer> GetAll(Expression<Func<Customer, bool>> filter = null)
        {
            using (NorthwindContext context = new())
            {
                return filter == null 
                    ? context.Set<Customer>().ToList() 
                    : context.Set<Customer>().Where(filter).ToList();
            }
        }

        public Customer Get(Expression<Func<Customer, bool>> filter)
        {
            using (NorthwindContext context = new())
            {
                return context.Set<Customer>().SingleOrDefault(filter);
            }
        }

        public void Update(Customer entity)
        {
            using (NorthwindContext context = new())
            {
                var updatedEntity = context.Update(entity);
                updatedEntity.State = EntityState.Modified;
                context.SaveChanges();
            }
        }
    }
}