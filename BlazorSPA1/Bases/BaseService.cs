using BlazorSPA1.Bases;
using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Http;

using System.Threading.Tasks;

namespace BlazorSPA1.Data
{
    public class BaseService<T> : IService<T>
    {
        private readonly HttpClient httpClient;
        public string Controller { get; set; }

        public BaseService(HttpClient httpClient)
        {
            this.httpClient = httpClient;
        }

        public async Task<bool> Create(T model)
        {
            var ret = await httpClient.PostAsJsonAsync($"api/{Controller}", model);
            return ret.StatusCode == HttpStatusCode.OK;
        }

        public Task<List<T>> Get()
        {
            throw new NotImplementedException();
        }

        public Task<bool> Edit(int id, T model)
        {
            throw new NotImplementedException();
        }

        public Task<T> GetById(int id)
        {
            throw new NotImplementedException();
        }

        public Task<bool> DeleteById(int id)
        {
            throw new NotImplementedException();
        }
    }
}
