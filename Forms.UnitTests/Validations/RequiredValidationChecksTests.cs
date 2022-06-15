using Forms.Business.Validation.Fields;
using Forms.Business.Forms;

namespace Forms.UnitTests.Validations
{
    public class RequiredValidationCheckTests
    {

        [Test]
        public void TestRequiredValidationPassing()
        {
            RequiredFieldValidation valid = new RequiredFieldValidation();
            Field test = new Field
            {
                Name = "test",
                Value = "Filled In"
            };
            Assert.IsTrue(valid.IsValid(test));
        }

        [Test]
        public void TestRequiredValidationFails()
        {
            RequiredFieldValidation valid = new RequiredFieldValidation();
            Field test = new Field
            {
                Name = "test",
                Value = ""
            };
            Assert.IsFalse(valid.IsValid(test));
        }

        [Test]
        public void TestRequiredValidationExplainsFail()
        {
            RequiredFieldValidation valid = new RequiredFieldValidation();
            Field test = new Field
            {
                Name = "test",
                Value = ""
            };
            Assert.IsFalse(valid.IsValid(test));
            Assert.IsTrue(valid.PrintValidationError(test) != string.Empty);
        }
    }
}