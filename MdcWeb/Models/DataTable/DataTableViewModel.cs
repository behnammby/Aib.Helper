using System.Collections.Generic;

namespace Behnammby.MdcWeb.Models.DataTable
{
    public class DataTableViewModel : Common.MdcWebBase
    {
        public DataTableVariant Variant {get;set;}
        public string Label {get;set;}
        public Row Head {get;set;}
        public IEnumerable<Row> Body {get;set;}
    }
}