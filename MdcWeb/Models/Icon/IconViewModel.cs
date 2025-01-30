namespace Behnammby.MdcWeb.Models.Icon
{
    public class IconViewModel : Common.MdcWebBase
    {
        public bool Clickable {get;set;} = false;
        public IconVariant Variant { get; set; }
        public string Icon { get; set; }
        public string IconOn { get; set; }
        public string Action { get; set; }

        public string GetTabIndex() => Clickable ? "0" : "-1";
    }
}
