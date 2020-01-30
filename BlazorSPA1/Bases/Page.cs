using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlazorSPA1.Bases
{
    public class Page<T>: ComponentBase
    {
        [Inject]
        public NavigationManager NavigationManager { get; set; }
        public T Model { get; set; }
        public IService<T> Service { get; set; }

        protected string ControlleBase { get; set; }
    }
}
