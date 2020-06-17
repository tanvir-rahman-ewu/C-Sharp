using System;
using System.Collections.Generic;
using System.Text;

namespace Interface_P.Factory
{
    class FactoryCreate
    {
        public Icalculator create()
        {
            return new Calculator();
        }
    }
}
