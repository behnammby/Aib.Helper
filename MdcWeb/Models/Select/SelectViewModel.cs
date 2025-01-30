using System.Linq;
using System.Collections.Generic;
using Behnammby.MdcWeb.Models.List;
using System;

namespace Behnammby.MdcWeb.Models.Select
{
    public class SelectViewModel : Common.MdcWebBase
    {
        public SelectVariant Variant { get; set; }
        public string Label { get; set; }
        public string InputName { get; set; }
        public IEnumerable<Group> Groups { get; set; }
        public bool ShowEmptyItem { get; set; } = true;
        public bool ShowInGroups {get;set;} = false;

        public string GetSelectedValue() {
            try {
                var Selected = Groups.SelectMany(g => g.Items).First(i => i.Selected);
                return Selected.Value;
            }
            catch (InvalidOperationException)
            {
                return string.Empty;
            }
        }
    }
}