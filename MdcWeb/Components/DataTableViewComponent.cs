using Behnammby.MdcWeb.Models.DataTable;
using Microsoft.AspNetCore.Mvc;

namespace Behnammby.MdcWeb.Components
{
    public class DataTableViewComponent : ViewComponent
    {
        public IViewComponentResult Invoke(DataTableViewModel model) => View(model);
    }
}
