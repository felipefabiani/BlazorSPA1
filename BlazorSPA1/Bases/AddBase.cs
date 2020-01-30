using Microsoft.AspNetCore.Components;
using System.Threading.Tasks;

namespace BlazorSPA1.Bases
{
    public class AddBase<T> : ComponentBase
    {
        public T Model { get; set; }
        public IService<T> Service { get; set; }

        [Inject]
        public NavigationManager NavigationManager { get; set; }

        public AddBase()
        {
        }

        protected async Task Create()
        {
            await Service.Create(Model);
            NavigationManager.NavigateTo("listemployees");
        }

        protected void Cancel()
        {
            NavigationManager.NavigateTo("listemployees");
        }
    }
}
