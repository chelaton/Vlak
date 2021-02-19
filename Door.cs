using System;
using System.Collections.Generic;
using System.Text;

namespace Vlak
{
    class Door
    {
        double height;
        double width;

        public Door()
        {
        }

        public double Height { get => height; set => height = value; }
        public double Width { get => width; set => width = value; }
    }
}
