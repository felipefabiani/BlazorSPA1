using Microsoft.AspNetCore.Components;
using System.Threading.Tasks;

namespace BlazorSPA1.Bases
{
    public class AddBase<T> : Page<T>
    { 
        protected async Task Create()
        {
            // await Service.Create(Model);
            await Task.Delay(10);
            NavigationManager.NavigateTo("counter", true);
        }

        protected Task Cancel()
        {
            NavigationManager.NavigateTo("/counter");
            return Task.CompletedTask;
        }
    }
}
