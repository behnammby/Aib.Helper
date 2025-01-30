using Behnammby.Mdc.Common;
using Behnammby.Mdc.Lists.Variants;
using Behnammby.Mdc.Models.Shared;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Rendering;
using Microsoft.JSInterop;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Behnammby.Mdc.Lists
{
    /// <summary>
    /// Lists are continuous, vertical indexes of text or images.
    /// </summary>
    public class List : CommonBase
    {
        [Parameter]
        public ListVariants Variant { get; set; } = ListVariants.SingleLine;

        [Parameter]
        public IEnumerable<Group> Groups { get; set; }

        protected override void BuildRenderTree(RenderTreeBuilder builder)
        {
            switch (Variant)
            {
                case ListVariants.SingleLine:
                case ListVariants.SingleNav:
                    try
                    {
                        var group = Groups.First();
                        BuildSingle(builder, group.Items, group.ShowGrphics);
                    }
                    catch (InvalidOperationException) { }
                    break;
                case ListVariants.TwoLine:
                    break;
                case ListVariants.Group:
                    break;
                default:
                    break;
            }
        }

        private void BuildSingle(RenderTreeBuilder builder, IEnumerable<Item> items, bool showGraphics)
        {
            var component = Variant == ListVariants.SingleLine ? typeof(SingleLine) : typeof(SingleNav);
            builder.OpenComponent(0, component);
            builder.AddAttribute(1, nameof(SingleBase.Items), items);
            builder.AddAttribute(2, nameof(SingleBase.ShowGraphics), showGraphics);
            builder.CloseComponent();
        }
    }
}
