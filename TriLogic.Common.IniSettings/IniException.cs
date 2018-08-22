using System;
using System.Collections.Generic;
using System.Text;

namespace Trilogic.Common.Settings
{
    public class IniException : Exception
    {
        public IniException(string msg)
            : base(msg)
        {
        }
    }
}
