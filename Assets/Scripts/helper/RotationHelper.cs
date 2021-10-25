using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assets.Scripts.helper
{
    public static class RotationHelper
    {
        public static float ToDegree(float quoteQuetern)
        {
            return ((quoteQuetern + 1) / 2) * 360;
        }
    }
}
