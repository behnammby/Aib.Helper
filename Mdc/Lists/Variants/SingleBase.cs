using Behnammby.Mdc.Common;
using Behnammby.Mdc.Models.Shared;
using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.Text;

namespace Behnammby.Mdc.Lists.Variants
{
    public class SingleBase : ListBase
    {
        [Parameter]
        public IEnumerable<Item> Items { get; set; }

        [Parameter]
        public bool ShowGraphics { get; set; }
    }
}
