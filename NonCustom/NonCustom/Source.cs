using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NonCustom
{
    class Source : ElectricElem
    {
        protected double ERS;
        protected double r;
        public Source ()
        {
            ERS = 1.5;
            r = 0.5;
        }
        public Source(double ERS)
        {
            this.ERS = ERS;
        }
        public Source(double ERS,double r)
        {
            this.ERS = ERS;
            this.r = r;
        }
    }
}
