using Forms.Business.Forms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Forms.Business.Validation.Fields
{
    public class IsDateValidation : ValidationCheck<Field>
    {
        public const string NAME = "Is a Date";
        public const string DESC = "Ensure that the value entered is a date";
        public IsDateValidation() : base(NAME, DESC)
        {
        }

        public override string PrintValidationError(Field item)
        {
            if (DateTime.TryParse(item.Value, out var _))
            {
                return $"{item.Name} must be a Date";
            }
            return String.Empty;
        }
    }
}
