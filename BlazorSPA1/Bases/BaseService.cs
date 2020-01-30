using BlazorSPA1.Bases;
using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Http;

using System.Threading.Tasks;

namespace BlazorSPA1.Data
{
    public class BaseService : IService<Employee>
    {
        private readonly HttpClient httpClient;

        public BaseService(HttpClient httpClient)
        {
            this.httpClient = httpClient;
        }

        public async Task<bool> Create(Employee model)
        {
            var ret = await httpClient.PostAsJsonAsync("api/TodoItems", model);
            return ret.StatusCode == HttpStatusCode.OK;
        }



        public Task<bool> DeleteById(int id)
        {
            throw new NotImplementedException();
        }

        public Task<bool> Edit(int id, Employee model)
        {
            throw new NotImplementedException();
        }

        public Task<List<Employee>> Get()
        {
            throw new NotImplementedException();
        }

        public Task<Employee> GetById(int id)
        {
            throw new NotImplementedException();
        }
    }
}
