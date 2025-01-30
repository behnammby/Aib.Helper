using System;
using System.Collections.Generic;
using System.Linq;

namespace Behnammby.MdcWeb.Models.Common
{
    public class MdcWebBase
    {
        protected virtual string Dense { get; } = string.Empty;
        public bool IsDense { get; set; }
        public string Id {get;set;}
        public int Elevation { get; set; }
        public IEnumerable<Validation> Validations { get; set; }
        public string CustomClass { get; set; }
        public string CustomClassId {get;set;}

        public string GetDense() => IsDense ? Dense : string.Empty;
        public virtual string GetElevation() => Elevation != default ? new Elevation(Elevation).ToString() : string.Empty;
        public virtual string GetValidations()
        {
            try
            {
                return string.Join(' ', Validations);
            }
            catch (ArgumentNullException)
            {
                return string.Empty;
            }
        }
    }
}
