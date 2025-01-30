using Behnammby.MdcWeb.Models.TabBar;
using Microsoft.AspNetCore.Mvc;

namespace Behnammby.MdcWeb.Components
{
    public class TabBarViewComponent : ViewComponent
    {
        public IViewComponentResult Invoke(TabBarViewModel model) => View(model);
    }
}
