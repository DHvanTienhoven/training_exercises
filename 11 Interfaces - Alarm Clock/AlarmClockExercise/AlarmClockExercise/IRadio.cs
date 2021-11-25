using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlarmClockExercise
{
    interface IRadio
    {
        void Play();
        bool IsPlaying { get; }
    }
}
