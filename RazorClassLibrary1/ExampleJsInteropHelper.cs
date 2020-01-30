using Microsoft.JSInterop;

using System.Threading.Tasks;

namespace RazorClassLibrary1
{
    public static class ExampleJsInteropHelper
    {
        public static ValueTask<string> Prompt(this IJSRuntime jsRuntime, string message)
        {
            
            // Implemented in exampleJsInterop.js
            return jsRuntime.InvokeAsync<string>(
                "exampleJsFunctions.showPrompt",
                message);
        }
    }
}
