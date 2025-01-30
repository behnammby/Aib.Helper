using Behnammby.MdcWeb.Models.Button;
using Microsoft.AspNetCore.Mvc;
using System;

namespace Behnammby.MdcWeb.Components
{
    public class ButtonViewComponent : ViewComponent
    {
        public IViewComponentResult Invoke(ButtonViewModel model)
        {
            switch (model.Variant)
            {
                case ButtonVariant.Default:
                case ButtonVariant.Contained:
                case ButtonVariant.ContainedElevated:
                case ButtonVariant.Outlined:
                    return View("Default", model);

                case ButtonVariant.DefaultAnchor:
                case ButtonVariant.ContainedAnchor:
                case ButtonVariant.ContainedElevatedAnchor:
                case ButtonVariant.OutlinedAnchor:
                    return View("DefaultAnchor", model);

                case ButtonVariant.IconButton:
                    return View("IconButton", model);

                case ButtonVariant.IconButtonToggle:
                    return View("IconButtonToggle", model);

                case ButtonVariant.IconButtonAnchor:
                    return View("IconButtonAnchor", model);

                default:
                    break;
            }

            throw new NotImplementedException($"Button variant {model.Variant.ToString()} not omplemented yet");
        }
    }
}
