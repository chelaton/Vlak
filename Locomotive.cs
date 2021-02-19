using System;
using System.Collections.Generic;
using System.Text;

namespace Vlak
{

    class Locomotive
    {
        private Person driver;
        private Engine engine;

        public Person Driver { get => driver; set => driver = value; }
        public Engine Engine { get => engine; set => engine = value; }

        public Locomotive()
        {
        }

        public Locomotive(Person driver, Engine engine)
        {
            this.Driver = driver;
            this.Engine = engine;
        }
        public override string ToString()
        {
            return $"Lokomotiva ma motor {Engine} a ridi ji {Driver} \r\n";
        }

    }
}
