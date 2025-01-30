using Behnammby.MdcWeb.Models.Drawer;
using Microsoft.AspNetCore.Mvc;

namespace Behnammby.MdcWeb.Components
{
    public class DrawerViewComponent : ViewComponent
    {
        public IViewComponentResult Invoke(DrawerViewModel model)
        {

            return View(model.Variant.ToString(), model);
        }
    }
}
