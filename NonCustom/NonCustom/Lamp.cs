using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Drawing;

namespace NonCustom
{
    class Lamp : Class1
    {
        bool IsClosed;
        bool burnUp;
        void Change()
        {
            Image i = Image.FromFile(filename: "lampochka.jpg");
            theButton.BackgroundImage = i;
        }
    }
}
