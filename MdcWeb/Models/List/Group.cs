using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Behnammby.MdcWeb.Models.List
{
    public class Group
    {
        public string Name { get; set; }
        public bool ShowGraphics { get; set; }
        public IEnumerable<Item> Items { get; set; }
    }
}
