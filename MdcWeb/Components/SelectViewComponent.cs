using Behnammby.MdcWeb.Models.Select;
using Microsoft.AspNetCore.Mvc;

namespace Behnammby.MdcWeb.Components {
    public class SelectViewComponent : ViewComponent {
        public IViewComponentResult Invoke(SelectViewModel model) {
            
            return View(model.Variant.ToString(), model);
        }
    }
}