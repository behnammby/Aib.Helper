using Behnammby.MdcWeb.Models.TopAppBar;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Behnammby.MdcWeb.Components
{
    public class TopAppBarViewComponent : ViewComponent
    {
        public IViewComponentResult Invoke(TopAppBarViewModel model)
        {
            return View(model.Variant.ToString() , model);
        }
    }
}
