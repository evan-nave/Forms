using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Forms.Business.Validation;

namespace Forms.Business.Forms
{
    public class Field
    {
        public string Name { get; set; }
        public string Value { get; set; }
        public string[] Options { get; set;}
        public List<ValidationCheck<Field>> Validations { get; set; }
    }
}
