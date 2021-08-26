using System;
using System.Collections.Generic;

namespace Domain.Contracts.Commons
{
    public interface IBaseRepository<T>
    {
        void Remove(T model);
        bool Update(T model);
        long Add(T model);
        T Fetch(Guid modelId);
        List<T> GetAll();
    }
}
