using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NonCustom
{
    public class Switch:ElectricElem
    {
        protected bool On;
       Switch()
        {
            On = true;
        }
        Switch(bool On)
        {
            this.On = On;
        }
    }
}