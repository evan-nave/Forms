using Forms.Business.Forms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Forms.Business.Validation.Fields
{
    public class RequiredFieldValidation : ValidationCheck<Field>
    {
        public const string Name = "Required";
        public const string Desc = "Ensure the field is filled in";
        public RequiredFieldValidation() : base(Name,Desc)
        {

        }

        public override string PrintValidationError(Field item)
        {
            if (string.IsNullOrWhiteSpace(item.Value) || string.IsNullOrEmpty(item.Value)) {
                return $"{item.Name} is required";
            }
            return string.Empty;
        }
    }
}
