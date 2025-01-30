using Behnammby.MdcWeb.Models.Button;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Behnammby.MdcWeb.Models.TopAppBar
{
    public class TopAppBarAction
    {
        public string SimpleText { get; set; }
        public string SimpleTextCustomClass {get;set;}

        public ButtonViewModel Button { get; set; }
    }
}
