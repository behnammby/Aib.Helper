using Microsoft.AspNetCore.Mvc;
using Behnammby.MdcWeb.Models.Radio;

public class RadioViewComponent : ViewComponent {
    public IViewComponentResult Invoke(RadioViewModel model) {
        return View(model.Variant.ToString(), model);
    }
}