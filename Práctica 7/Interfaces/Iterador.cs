using System;
using System.Collections.Generic;
using System.Text;

namespace Práctica_7
{
    interface Iterador
    {
        public void inicial();
        public void siguiente();
        public bool fin();
        public object actual();
    }
}
