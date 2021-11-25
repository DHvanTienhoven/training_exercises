using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlarmClockExercise
{
    class AlarmClock: Device, IClock, IRadio
    {
        public bool IsPlaying { get; private set; }
        public bool IsAlarmOn { get; private set; }

        public enum AlarmMode
        {
            Radio,
            Beeping
        }

        public AlarmMode Mode { get; set; }
   

        public void Play()
        {
            IsPlaying = true;
        }

        public void TurnOnAlarm()
        {
            if(Mode == AlarmMode.Radio)
            {
                IsPlaying = true;
            }

            IsAlarmOn = true;
        }


    }
}
