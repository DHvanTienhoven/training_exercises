using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlarmClockExercise
{
    class WristWatch: Device, IClock
    {
        public bool IsAlarmOn { get; private set; }

        public void TurnOnAlarm()
        {
            IsAlarmOn = true;
        }



    }
}
