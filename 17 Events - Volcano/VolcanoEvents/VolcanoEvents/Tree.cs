using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VolcanoEvents
{
    class Tree
    {
        /// <summary>
        /// Is burning when <see cref="Volcano.DangerLevel"/> == Erupting
        /// </summary>
        public bool IsBurning
        {
            get;
            private set;
        }

        // TODO: Construct and listen to the volcano
    }
}
