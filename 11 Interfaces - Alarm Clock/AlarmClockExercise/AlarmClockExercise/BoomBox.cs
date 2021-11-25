using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlarmClockExercise
{
    class BoomBox : Device, IRadio
    {
        public bool IsPlaying { get; private set; }

        public void Play()
        {
            IsPlaying = true;
        }


    }
}
