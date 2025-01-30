using Behnammby.Mdc.Models.Shared;
using System;
using System.Collections.Generic;
using System.Text;

namespace Behnammby.Mdc.Lists
{
    public class ListParams
    {
        public ListVariants Variant { get; set; } = ListVariants.SingleLine;

        public IEnumerable<Group> Groups { get; set; }
    }
}
