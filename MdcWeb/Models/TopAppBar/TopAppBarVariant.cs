using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Behnammby.MdcWeb.Models.TopAppBar
{
    public enum TopAppBarVariant : byte
    {
        Default,
        DefaultNoMenu,
        DefaultShowActions,
        DefaultNoMenuShowActions,
        Brand,
        BrandNoMenu,
        BrandShowActions,
        BrandNoMenuShowActions
    }
}
