﻿using System;
namespace Business_Logic.Interfaces
{
    public interface IRepository<T1> where T1 : class
    {
        List<T1> GetAll();
        T1? GetById(string id);
        void Insert(T1 entity);
        void Update(T1 entity);
        void Delete(string id);
    }
}

