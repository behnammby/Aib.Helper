using System.Linq;
using Behnammby.MdcWeb.Models.List;
using Microsoft.AspNetCore.Mvc;

namespace Behnammby.Common.Components 
{
    public class ValidationSummaryViewComponent : ViewComponent
    {
        public IViewComponentResult Invoke(string customClass = null)
        {
            var errors = ViewContext.ModelState.Values.SelectMany(x => x.Errors);
            var model = new ListViewModel
            {
                Groups = new[]
                {
                    new Group
                    {
                        Items = errors.Select(x => new Item { 
                            Text = x.ErrorMessage
                        })
                    }
                },
                Variant = ListVariant.Default,
                CustomClass = customClass
            };

            return View(model);
        }
    }
}