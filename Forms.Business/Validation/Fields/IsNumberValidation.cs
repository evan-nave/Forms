using Forms.Business.Forms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Forms.Business.Validation.Fields
{
    public class IsNumberValidation : ValidationCheck<Forms.Field>
    {
        public const string NAME = "Is A Number";
        public const string DESC = "Ensure that the value entered is a number";

        public IsNumberValidation() : base(NAME, DESC)
        {
        }

        public override string PrintValidationError(Field item)
        {
            bool isInt = int.TryParse(item.Value, out var _);
            bool isDouble = double.TryParse(item.Value, out var _);
            return isDouble || isInt ? string.Empty : $"{item.Name} must be a number";
        }
    }
}
