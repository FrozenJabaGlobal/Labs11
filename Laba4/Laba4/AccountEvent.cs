using System;
using System.Collections.Generic;
using System.Text;

namespace Prog
{
    class AccountEvent:EventArgs
    {
        public readonly string message;
        public AccountEvent(string msg) => message = msg;
    }
}