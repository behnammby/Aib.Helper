using Behnammby.MdcWeb.Models.TextField;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Behnammby.MdcWeb.Components
{
    public class TextFieldViewComponent : ViewComponent
    {
        public IViewComponentResult Invoke(TextFieldViewModel model)
        {
            return View(model.Variant.ToString(), model);
        }
    }
}
