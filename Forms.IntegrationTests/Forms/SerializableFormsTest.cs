using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using Forms.Business.Validation;
using Forms.Business.Validation.Fields;
using Forms.Business.Forms;
using Newtonsoft.Json;

namespace Forms.IntegrationTests.Forms
{
    internal class SerializableFormsTest
    {
        [Test]
        public void EnsureValidationCheckIsSerializable() { 
           ValidationCheck<Field> check = new NumberRangeValidation(1,4);
           string result = JsonConvert.SerializeObject(check.GetMemento());
           Assert.IsNotEmpty(result);
        }
    }
}
