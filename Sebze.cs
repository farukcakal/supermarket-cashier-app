using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Odev_1
{
    class Sebze
    {
        public decimal price;
    }
    class Patlican : Sebze
    {
        public void setValues()
        {
            price = 5;
        }
    }

    class Havuc : Sebze
    {
        public void setValues()
        {
            price = Convert.ToDecimal(0.5);
        }
    }

    class Kabak : Sebze
    {
        public void setValues()
        {
            price = Convert.ToDecimal(4.5);
        }
    }

    class Limon : Sebze
    {
        public void setValues()
        {
            price = Convert.ToDecimal(5.5);
        }
    }
}
