using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Option3
{
    /// <summary>
    /// Исключение для специфических задач, класса Person
    /// </summary>
    public class PersonException : Exception
    {
        public PersonException(string message)
            : base(message)
        { }
    }
}

