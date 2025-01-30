using Behnammby.MdcWeb.Models.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Behnammby.MdcWeb.Models.TopAppBar
{
    public class TopAppBarViewModel : MdcWebBase
    {
        protected override string Dense { get; } = "mdc-top-app-bar--dense";

        public TopAppBarVariant Variant { get; set; }
        public string Title { get; set; }
        public string Brand { get; set; }
        public IEnumerable<TopAppBarAction> Actions { get; set; }
    }
}
