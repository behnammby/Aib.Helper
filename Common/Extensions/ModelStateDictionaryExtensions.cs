using System.Collections.Generic;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc.ModelBinding;

namespace Behnammby.Common.Extensions
{
    public static class ModelStateDictionaryExtensions
    {
        public static void AddModelErrors(this ModelStateDictionary dic, IEnumerable<IdentityError> errors)
        {
            if (errors != null)
            {
                foreach (var item in errors)
                {
                    dic.AddModelError(item.Code, item.Description);
                }
            }
        }
    }
}