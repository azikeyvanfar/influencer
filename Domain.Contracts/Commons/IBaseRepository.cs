using System;
using System.Collections.Generic;

namespace Domain.Contracts.Commons
{
    public interface IBaseRepository<T>
    {
        void Delete(T model);
        bool Update(T model);
        long Insert(T model);
        T Fetch(Guid modelId);
        List<T> GetAll();
    }
}
