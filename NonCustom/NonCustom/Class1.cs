using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Windows.Forms;

namespace NonCustom
{
    public class ElectricElem
    {
        protected Button theButton;
        protected Button Prop;//Propetry button
        protected GroupBox Gpb;
        protected ElectricElem LeftElem;//Link to left element
        protected ElectricElem RightElem;//Link to right element
        public ElectricElem()
        {
            Prop.Hide();
        }
    }
}
