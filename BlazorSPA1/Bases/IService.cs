using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlazorSPA1.Bases
{
    public interface IService<T>
    {
        Task<List<T>> Get();
        Task<bool> Create(T model);
        Task<bool> Edit(int id, T model);
        Task<T> GetById(int id);
        Task<bool> DeleteById(int id);
    }
}
