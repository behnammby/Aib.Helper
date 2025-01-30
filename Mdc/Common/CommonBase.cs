using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Behnammby.Mdc.Common
{
    public abstract class CommonBase : ComponentBase
    {
        protected ElementReference ElementRef { get; set; }

        [Inject]
        protected IJSRuntime JsInterop { get; set; }

        protected async Task InitMdcComponent(string func)
        {
            Console.WriteLine($"Going to init {func}");

            var objectRef = DotNetObjectReference.Create(this);
            await JsInterop.InvokeVoidAsync(func, ElementRef, objectRef);
        }
    }
}
