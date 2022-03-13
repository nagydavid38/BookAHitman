// <copyright file="ContinentalRepo.cs" company="PlaceholderCompany">
// Copyright (c) PlaceholderCompany. All rights reserved.
// </copyright>

namespace Continental.Repository
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Linq.Expressions;
    using System.Reflection;
    using System.Text;
    using System.Threading.Tasks;

    using Continental.Data;

    public interface IDynamicRepo<T> where T : class
    {
        IQueryable<T> GetAll();
        void Create(T newModel);
        void Update(int id, string columnToUpdate, string val);
        void Delete(int id);
    }

    public class DynamicRepo<T> : IDynamicRepo<T> where T : class
    {
        private ContinentalDataEntities db = new ContinentalDataEntities();
        public void Create(T newModel)
        {
            db.Set<T>().Add(newModel);
            db.SaveChanges();
        }

        public void Delete(int id)
        {
            string idName = typeof(T).GetProperties().Select(x => x.Name).ToList().First(y => y.Contains("ID"));
            PropertyInfo typeId = typeof(T).GetProperty(idName);
            ParameterExpression pe = Expression.Parameter(typeof(T), "x");
            Expression left = Expression.PropertyOrField(pe, idName);
            Expression right = Expression.Constant(Convert.ChangeType(id,typeId.PropertyType), left.Type);
            Expression e1 = Expression.Equal(left, right);
            var predicate = Expression.Lambda<Func<T, bool>>(e1, pe);
            var result = db.Set<T>().Single(predicate);
            db.Set<T>().Remove(result);

        }

        public IQueryable<T> GetAll()
        {
            return db.Set<T>().Select(x => x);
        }

        public void Update(int id, string columnToUpdate, string val)
        {
            string idName = typeof(T).GetProperties().Select(x => x.Name).ToList().First(y => y.Contains("ID"));
            PropertyInfo typeId = typeof(T).GetProperty(idName);
            PropertyInfo typeColumn = typeof(T).GetProperty(columnToUpdate);
            ParameterExpression pe = Expression.Parameter(typeof(T), "x");
            Expression left = Expression.PropertyOrField(pe, idName);
            Expression right = Expression.Constant(Convert.ChangeType(id, typeId.PropertyType), left.Type);
            Expression e1 = Expression.Equal(left, right);
            var predicate = Expression.Lambda<Func<T, bool>>(e1, pe);
            var toUpdate = db.Set<T>().Single(predicate);
            var convertedVal = Convert.ChangeType(val, typeColumn.PropertyType);
            toUpdate.GetType().GetProperty(columnToUpdate).SetValue(toUpdate, convertedVal);

        }
    }

   

   
   
}
