using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DecoratorTranslucent
{
    class Decorator : Document
    {
        private Document document;

        public Decorator(Document document)
        {
            this.document = document;
        }

        public override void Display()
        {
            document.Display();
        }
    }
}
