using System;
using System.Collections.Generic;
using System.Text;

namespace property
{
    class Television
    {
        private string name;
        private int price;

        public void set_name(string name)
        {
            this.name = name;
        }
        public string get_name()
        {
            return name;
        }

        public void set_price(int price)
        {
            this.price = price;
        }
        public int get_price()
        {
            return price;
        }
    }
}
