using Behnammby.Mdc.Common;
using Microsoft.AspNetCore.Components;
using Microsoft.JSInterop;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Behnammby.Mdc.Lists.Variants
{
    public class ListBase : CommonBase
    {
        protected override async Task OnAfterRenderAsync(bool firstRender)
        {
            if (firstRender)
            {
                await InitMdcComponent("behnammby.mdc.list.init");
            }

            await base.OnAfterRenderAsync(firstRender);
        }
    }
}
