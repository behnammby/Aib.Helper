namespace Behnammby.MdcWeb.Models.TabBar
{
    public class Tab
    {
        private const string ActiveClass = "mdc-tab--active";
        private const string ActiveIndicatorClass = "mdc-tab-indicator--active";

        public string Icon {get;set;}
        public string Label {get;set;}
        public string Action {get;set;}
        public bool IsActive {get;set;} = false;

        public string GetActiveClass() => IsActive ? ActiveClass : string.Empty;
        public string GetActiveIndicatorClass() => IsActive ? ActiveIndicatorClass : string.Empty;
    }
}