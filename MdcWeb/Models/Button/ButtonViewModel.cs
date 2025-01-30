using Behnammby.MdcWeb.Models.Icon;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Behnammby.MdcWeb.Models.Button
{
    public class ButtonViewModel : Common.MdcWebBase
    {
        private const string Contained = "mdc-button--unelevated";
        private const string ContainedElevated = "mdc-button--raised";
        private const string Outlined = "mdc-button--outlined";
        protected override string Dense { get; } = "mdc-button--dense";

        public ButtonVariant Variant { get; set; }
        public ButtonType Type { get; set; }
        public IconViewModel Icon { get; set; }
        public string Label { get; set; }
        public string Action { get; set; }
        public string Value { get; set; }

        public string GetExtraClass()
        {
            switch (Variant)
            {
                case ButtonVariant.Contained:
                case ButtonVariant.ContainedAnchor:
                    return Contained;

                case ButtonVariant.ContainedElevated:
                case ButtonVariant.ContainedElevatedAnchor:
                    return ContainedElevated;

                case ButtonVariant.Outlined:
                case ButtonVariant.OutlinedAnchor:
                    return Outlined;

                case ButtonVariant.IconButton:
                    return string.Empty;
                    
                case ButtonVariant.IconButtonToggle:
                    return string.Empty;

                case ButtonVariant.Default:
                case ButtonVariant.DefaultAnchor:
                default:
                    return string.Empty;
            }
        }
    }
}
