using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace BlazorSPA1.Helpers
{
    public static class ObjectHelper
    {
        public static StringContent GetStringContent(this object obj)
        {
            return new StringContent(obj.ToString(), Encoding.UTF8, "application/json");
        }
            

    }
}
