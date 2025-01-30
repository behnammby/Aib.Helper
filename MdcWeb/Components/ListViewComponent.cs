using Behnammby.MdcWeb.Models.List;
using Microsoft.AspNetCore.Mvc;

namespace Behnammby.MdcWeb.Components
{
    public class ListViewComponent : ViewComponent
    {
        public IViewComponentResult Invoke(ListViewModel model)
        {
            return View(model.Variant.ToString(), model);
        }
    }
}
