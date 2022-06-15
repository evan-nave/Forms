using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Forms.Business.Validation
{
    /// <summary>
    /// a class to use 
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public abstract class ValidationCheck<T> where T : class
    {
        public string Name { get; private set; }
        public string Description { get; private set; }

        protected ValidationCheck(string name, string desc)
        {
            Name = name;
            Description = desc;
        }

        /// <summary>
        /// print out a message that explains what's wrong with the object. return string.Empty if nothing is wrong
        /// </summary>
        /// <param name="item">the item potentialy with an issue</param>
        /// <returns>a message on what is wrong</returns>
        public abstract string PrintValidationError(T item);
        public virtual ValidationMemento GetMemento()
        {
            return new ValidationMemento() { Name = Name, Properties = new Dictionary<string, string>() };
        }
        public bool IsValid(T item) => string.IsNullOrEmpty(PrintValidationError(item));
    }

    public class ValidationMemento { 
        public string Name { get; set; }
        public Dictionary<string, string> Properties { get; set; }
    }
}
