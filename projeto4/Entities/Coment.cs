using System;
using System.Collections.Generic;
using System.Text;

namespace projeto4.Entities
{
    class Coment
    {
        public string Text { get; set; }

        public Coment()
        {
        }

        public Coment (string text)
        {
            Text = text;
        }
    }
}
