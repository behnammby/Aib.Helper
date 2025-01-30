using System.Collections.Generic;

namespace Behnammby.MdcWeb.Models.TabBar
{
    public class TabBarViewModel : Common.MdcWebBase
    {
        public IEnumerable<Tab> Tabs {get;set;}
    }
}