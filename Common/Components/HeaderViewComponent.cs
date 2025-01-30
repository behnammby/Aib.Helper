using Behnammby.MdcWeb.Models.TopAppBar;
using Behnammby.MdcWeb.Models.Drawer;
using Behnammby.Common.Models;
using Behnammby.MdcWeb.Models.List;
using Microsoft.AspNetCore.Mvc;

namespace Behnammby.Common.Components
{
    public class HeaderViewComponent : ViewComponent
    {
        public IViewComponentResult Invoke(string title, int elevation)
        {
            return View(new HeaderViewModel
            {
                Drawer = GetDrawer(),
                TopAppBar = GetTopAppBar(title, elevation)
            });
        }

        private TopAppBarViewModel GetTopAppBar(string title, int elevation)
        {
            return new TopAppBarViewModel
            {
                Variant = TopAppBarVariant.DefaultNoMenu,
                Title = title,
                IsDense = true,
                Elevation = elevation,
                CustomClass = "bmk-app-bar"
            };
        }

        private DrawerViewModel GetDrawer()
        {
            return new DrawerViewModel
            {
                Variant = DrawerVariant.DefaultBelowTopAppBar,
                Groups = new[] {
                    new Group {
                        Name = "",
                        Items = new[] {
                            new Item {
                            }
                        }
                    }
                }
            };
        }
    }
}