using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns_Assignment.Decorator.Decorators
{
    public class Smaller : HTMLDecorator
    {
        public Smaller(IDecorator textInput) : base(textInput)
        {
            HtmlTag = "small";
        }
    }
}

