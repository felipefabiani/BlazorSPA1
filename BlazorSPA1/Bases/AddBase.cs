using Microsoft.AspNetCore.Components;
using System.Threading.Tasks;

namespace BlazorSPA1.Bases
{
    public class AddBase<T> : ComponentBase
    {
        public T Model { get; set; }

        protected async Task CreateEmployee()
        {
            await EmployeeService.CreateEmployee(Model);
            NavigationManager.NavigateTo("listemployees");
        }

        void Cancel()
        {
            NavigationManager.NavigateTo("listemployees");
        }
    }
}
