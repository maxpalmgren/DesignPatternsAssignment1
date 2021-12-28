using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns_Assignment.Decorator
{
    public abstract class HTMLDecorator : IDecorator
    {
        IDecorator Text { get; set; }
        public string HtmlTag { get; set; }

        public HTMLDecorator(IDecorator text)
        {
            Text = text;
        }

        public string GetText()
        {
            return "<"+HtmlTag+">" + Text.GetText()+ "</" + HtmlTag + ">";
        }
    }
}                          
