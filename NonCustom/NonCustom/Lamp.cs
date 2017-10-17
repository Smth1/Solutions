using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Drawing;

namespace NonCustom
{
    class Lamp : ElectricElem
    {
        bool IsClosed;
        bool burnUp;
        Lamp()
        {
            IsClosed = false;
            burnUp = false;
        }
        void Change()
        {
            Image i = Image.FromFile(filename: "lampochka.jpg");
            theButton.BackgroundImage = i;
        }
    }
}
