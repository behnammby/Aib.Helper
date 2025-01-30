using Behnammby.MdcWeb.Models.Common;
using Behnammby.MdcWeb.Models.List;
using System.Collections.Generic;

namespace Behnammby.MdcWeb.Models.Drawer
{
    public class DrawerViewModel : MdcWebBase
    {
        public DrawerVariant Variant { get; set; }
        public IEnumerable<Group> Groups { get; set; }

        public ListViewModel GetList()
        {
            return new ListViewModel
            {
                Groups = Groups,
                Variant = ListVariant.Nav
            };
        }
    }
}