using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Odev_1
{
    class Meyve
    {
        public decimal price;
    }
    class Elma : Meyve
    {
        public void setValues()
        {
            price = 3;
        }
    }
    class Armut : Meyve
    {
        public void setValues()
        {
            price = 4;
        }
    }

    class Portakal : Meyve
    {
        public void setValues()
        {
            price = Convert.ToDecimal(1.5);
        }
    }

    class Uzum : Meyve
    {
        public void setValues()
        {
            price = Convert.ToDecimal(2.5);
        }
    }
}
