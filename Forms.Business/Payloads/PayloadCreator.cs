using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Forms.Business.Payloads
{
    /// <summary>
    /// an object that contains the user input from a form
    /// </summary>
    public abstract class PayloadCreator
    {
        public string Name { get; private set; }
        public string Description { get; private set; }
        protected PayloadCreator(string name, string desc)
        {
            Name = name;
            Description = desc;
        }

        public abstract string CreateFrom(Forms.Form form);
    }
}
