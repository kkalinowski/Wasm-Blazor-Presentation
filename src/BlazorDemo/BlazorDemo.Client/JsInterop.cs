using System.Threading.Tasks;
using Microsoft.JSInterop;

namespace BlazorDemo.Client
{
    public static class JsInterop
    {
        public static Task Log(string message)
        {
            return JSRuntime.Current.InvokeAsync<string>("console.log", message);
        }
    }
}