using System;
using System.Collections.Generic;
using System.Text;

namespace property
{
    class Car
    {
        private string name;
        private int price;

        public string Name
        {
            set { name = value; }
            get { return name; }
        }

        public int Price
        {
            set { price = value;  }
            get { return price;  }
        }
    }
}
