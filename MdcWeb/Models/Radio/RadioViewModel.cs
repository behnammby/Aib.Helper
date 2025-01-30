namespace Behnammby.MdcWeb.Models.Radio
{
    public class RadioViewModel : Common.MdcWebBase
    {
        public RadioVariant Variant { get; set; }

        public string InputId { get; set; }
        public string InputName { get; set; }
        public bool Checked { get; set; } = false;
        public string Label { get; set; }
        public object Value { get; set; }
        public string Action {get;set;}

        public string GetChecked()
        {
            return Checked ? "checked" : string.Empty;
        }

    }
}