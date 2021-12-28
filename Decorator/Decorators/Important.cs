﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns_Assignment.Decorator.Decorators
{
    class Important : HTMLDecorator
    {
        public Important(IDecorator textInput) : base(textInput)
        {
            HtmlTag = "important";
        }
    }
}

