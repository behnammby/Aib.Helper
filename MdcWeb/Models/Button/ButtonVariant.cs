using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Behnammby.MdcWeb.Models.Button
{
    public enum ButtonVariant : byte
    {
        Default,
        Contained,
        ContainedElevated,
        Outlined,
        DefaultAnchor,
        ContainedAnchor,
        ContainedElevatedAnchor,
        OutlinedAnchor,
        IconButton,
        IconButtonToggle,
        IconButtonAnchor
    }
}
