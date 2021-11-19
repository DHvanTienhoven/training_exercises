using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VolcanoEvents
{
    static class EnumUtils
    {
        public static T GetHighestEnumValue<T>()
        {
            return Enum.GetValues(typeof(T)).Cast<T>().Max();
        }
    }
}
