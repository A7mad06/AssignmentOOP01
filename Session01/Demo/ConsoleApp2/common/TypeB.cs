using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace common
{
    internal class TypeB
    {
        public TypeB()
        {
            TypeA a = new TypeA();
            //a.x = 10; Invalid
            a.y = 10;//Internal Valid
            a.z = 100;//Public Valid
        }
    }
}
