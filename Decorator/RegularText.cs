using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns_Assignment.Decorator
{
    public class RegularText : IDecorator
    {
        public string Text { get; set; }

        public RegularText(string textInput)
        {
            Text = textInput;
        }

        public string GetText()
        {
            return Text;
        }
    }
}
