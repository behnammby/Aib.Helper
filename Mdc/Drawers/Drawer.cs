using Behnammby.Mdc.Common;
using Behnammby.Mdc.Drawers.Variants;
using Behnammby.Mdc.Models.Shared;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;
using Microsoft.JSInterop;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Behnammby.Mdc.Drawers
{
    public partial class Drawer : CommonBase
    {

        [Parameter]
        public DrawerVariants Variant { get; set; } = DrawerVariants.Simple;

        [Parameter]
        public IEnumerable<Group> Groups { get; set; }

        protected override void BuildRenderTree(RenderTreeBuilder builder)
        {
            if (Variant == DrawerVariants.Simple)
            {
                BuildSimple(builder);
            }
        }

        private void BuildSimple(RenderTreeBuilder builder)
        {
            builder.OpenComponent(0, typeof(Simple));
            builder.AddAttribute(1, nameof(Simple.Groups), Groups);
            builder.CloseComponent();
        }
    }
}
