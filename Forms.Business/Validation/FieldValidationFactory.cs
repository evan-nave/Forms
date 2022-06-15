using Forms.Business.Forms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Forms.Business.Validation
{
    public class FieldValidationFactory
    {
        public FieldValidationFactory()
        {
        }

        /// <summary>
        /// Get the validation check by the name given
        /// </summary>
        /// <param name="name"></param>
        /// <exception cref="ArgumentException"></exception>
        /// <returns></returns>
        public ValidationCheck<Field> GetValidationByMemento(ValidationMemento validation) {
            switch (validation.Name) {
                case Fields.RequiredFieldValidation.Name:
                    return new Fields.RequiredFieldValidation();
                case Fields.IsNumberValidation.NAME:
                    return new Fields.IsNumberValidation();
                case Fields.NumberRangeValidation.NAME:
                    return new Fields.NumberRangeValidation(int.Parse(validation.Properties["min"]), int.Parse(validation.Properties["max"]));
                case Fields.IsDateValidation.NAME:
                    return new Fields.IsDateValidation();
                default:
                    throw new ArgumentException($"There is no validation check for '{validation.Name}'");
            }
        }
    }
}
