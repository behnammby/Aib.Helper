using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Behnammby.MdcWeb.Models.Checkbox
{
    public class CheckboxViewModel : Common.MdcWebBase
    {
        public string Name { get; set; }
        public CheckboxVariant Variant { get; set; }
        public string Label { get; set; }
        public bool Checked {get;set;}
    }
}
