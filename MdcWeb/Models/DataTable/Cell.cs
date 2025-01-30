namespace Behnammby.MdcWeb.Models.DataTable
{
    public class Cell
    {
        private const string NumericCellClass = "mdc-data-table__cell--numeric";
        public CellDataType DataType {get;set;}
        public string Data {get;set;}

        public string GetTypeClass() {
            if (DataType == CellDataType.Numeric) {
                return NumericCellClass;
            }

            return string.Empty;
        }
    }
}