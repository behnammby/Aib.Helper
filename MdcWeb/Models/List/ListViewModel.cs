using System.Collections.Generic;

namespace Behnammby.MdcWeb.Models.List
{
    public class ListViewModel : Common.MdcWebBase
    {
        public ListVariant Variant { get; set; }
        public IEnumerable<Group> Groups { get; set; }
        public bool ShowDefaultItem {get;set;} = false;
    }
}
