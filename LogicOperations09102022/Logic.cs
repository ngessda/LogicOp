using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace LogicOperations09102022
{
    public static class Logic
    {
        public static bool OpAnd(bool firstArg, bool secondArg)
        {
            return firstArg && secondArg;
        }

        public static bool OpOr(bool firstArg, bool secondArg)
        {
            return firstArg || secondArg;
        }
        public static bool OpInversion(bool Arg)
        {
            return !Arg;
        }
        public static bool OpInvOr(bool firstArg, bool secondArg)
        {
            return firstArg ^ secondArg;
        }
        public static bool OpImp(bool firstArg, bool secondArg)
        {
            return firstArg == false && secondArg == true ? false : true;
        }
        public static bool OpPred(bool firstArg, bool secondArg)
        {
            return OpInversion(firstArg) == false && secondArg == false ? false : true;
        }
        public static bool XOR(bool firstArg, bool secondArg)
        {
            return firstArg ^ secondArg;
        }

    }
}
