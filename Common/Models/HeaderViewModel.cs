using Behnammby.MdcWeb.Models.Drawer;
using Behnammby.MdcWeb.Models.TopAppBar;

namespace Behnammby.Common.Models
{
    public class HeaderViewModel
    {
        public DrawerViewModel Drawer {get;set;}
        public TopAppBarViewModel TopAppBar {get;set;}
    }
}