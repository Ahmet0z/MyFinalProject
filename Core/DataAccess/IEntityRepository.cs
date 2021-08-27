using Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace Core.DataAccess
{
    //Generic Constraint
    //class : referans tip olabilir
    //new() : new'lenebilir olmalı
    //T bir referans tip, IEntity veya IEntity implement eden bir nesne ve new'lenebilir olmalı
    public interface IEntityRepository<T> where T:class,IEntity,new()
    {
        void Add(T entity);
        void Delete(T entity);
        void Update(T entity);
        T Get(Expression<Func<T, bool>> filter = null);
        List<T> GetAll(Expression<Func<T,bool>> filter=null);
    }
}