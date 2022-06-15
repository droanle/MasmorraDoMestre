using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MasmorraDoMestre.Model
{
    public  class AtribultiColor
    {
         int r = 0;
         int g = 0;
         int b = 0;

        public  int R { get { return r; } set { r = value; } }
        public  int G { get { return g; } set { g = value; } }
        public  int B { get { return b; } set { b = value; } }

        public string getColor() { return r + "-" + g + "-" + b; }
    }
}
