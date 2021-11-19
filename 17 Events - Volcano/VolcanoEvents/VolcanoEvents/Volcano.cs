using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VolcanoEvents
{
    class Volcano
    {
        private DangerLevel _danger = DangerLevel.Sleeping;

        public enum DangerLevel
        {
            Sleeping,
            Smoking,
            FallingRocks,
            Erupting
        }

        public void IncreaseDanger()
        {
            if(_danger != EnumUtils.GetHighestEnumValue<DangerLevel>())
            {
                // TODO: Increase danger level and notify via an event
            }
        }
    }
}
