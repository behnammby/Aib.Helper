using Behnammby.Mdc.Common;
using Microsoft.JSInterop;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Behnammby.Mdc.Drawers.Variants
{
    public class DrawerBase : CommonBase
    {
        protected override async Task OnAfterRenderAsync(bool firstRender)
        {
            if (firstRender)
            {
                await InitMdcComponent("behnammby.mdc.drawer.init");
            }

            await base.OnAfterRenderAsync(firstRender);
        }
    }
}
