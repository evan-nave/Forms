using Forms.Business.Forms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Forms.Business.Validation.Fields
{
    public class NumberRangeValidation : ValidationCheck<Forms.Field>
    {
        public const string NAME = "Number Range";
        public const string Desc = "Ensure a number is within a certain range";

        int min;
        int max;
        public NumberRangeValidation(int min, int max) : base(NAME, Desc)
        {
            this.min = min < max ? min : max;
            this.max = min > max? min: max;
        }
        public override ValidationMemento GetMemento()
        {
            var mento = base.GetMemento();
            mento.Properties.Add(nameof(min), min.ToString());
            mento.Properties.Add(nameof(max), max.ToString());
            return mento;
        }
        public override string PrintValidationError(Field item)
        {
            if (int.TryParse(item.Value, out var _) == false)
            {
                return $"{item.Name} must be a number";
            }
            int number = int.Parse(item.Value);
            if (number < min)
            {
                return $"{item.Name} must be greater than {min}";
            }
            if (number > max)
            {
                return $"{item.Name} must be less than {max}";
            }
            return String.Empty;
        }
    }
}
