using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns_Assignment.Decorator.Decorators
{
    class Superscript : HTMLDecorator
    {
        public Superscript(IDecorator textInput) : base(textInput)
        {
            HtmlTag = "sup";
        }
    }
}

