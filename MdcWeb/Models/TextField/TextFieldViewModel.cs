using Behnammby.MdcWeb.Models.Common;
using Behnammby.MdcWeb.Models.Icon;
using System.Collections.Generic;

namespace Behnammby.MdcWeb.Models.TextField
{
    public class TextFieldViewModel : MdcWebBase
    {
        private const string LeadingIconClass = "mdc-text-field--with-leading-icon";
        private const string TrailingIconClass = "mdc-text-field--with-trailing-icon";
        private const string FullWidthClass = "mdc-text-field--fullwidth";

        public TextFieldVariant Variant { get; set; }
        public string Name { get; set; }
        public string Label { get; set; }
        public string Value { get; set; }
        public string HelperText { get; set; }
        public IconViewModel Icon { get; set; }
        public TextFiledType Type { get; set; }
        public bool IsFullWidth { get; set; } = true;

        public int TextAreaRows {get;set;}
        public int TextAreaCols {get;set;}

        public string GetExtraClass()
        {
            if (Icon?.Variant == IconVariant.Leading || Icon?.Variant == IconVariant.LeadingToggle)
            {
                return LeadingIconClass;
            }

            if (Icon?.Variant == IconVariant.Trailing || Icon?.Variant == IconVariant.TrailingToggle)
            {
                return TrailingIconClass;
            }

            return string.Empty;
        }
        public string GetFullWidthClass() => IsFullWidth ? FullWidthClass : string.Empty;
        public string GetPlaceHolder()
        {
            if (IsFullWidth)
            {
                return Label;
            }
            else
            {
                return string.Empty;
            }
        }
    }
}
