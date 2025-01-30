using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Behnammby.MdcWeb.Models.List
{
    public class Item
    {
        private const string SelectedItemClass = "mdc-list-item--selected";

        public string Text { get; set; }
        public string Value {get;set;}
        public string Graphic { get; set; }
        public string Href { get; set; }
        public bool Selected { get; set; } = false;
        public RouteTagHelper RouteTagHelper {get;set;}
        
        public string GetSelectedClass() {
            if (Selected) {
                return SelectedItemClass;
            }

            return string.Empty;
        }
    }
}
