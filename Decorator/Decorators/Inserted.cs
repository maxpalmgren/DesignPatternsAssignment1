using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns_Assignment.Decorator.Decorators
{
    class Inserted : HTMLDecorator
    {
        public Inserted(IDecorator textInput) : base(textInput)
        {
            HtmlTag = "ins";
        }
    }
}

