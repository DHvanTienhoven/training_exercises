using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AlarmClockExercise
{
    [TestClass]
    public class AlarmClockTests
    {
        [TestMethod]
        public void PlayDifferentTypesofRadios()
        {
            List<Device> devices = new List<Device>
            {
                new BoomBox(),
                new AlarmClock(),
                new WristWatch()
            };

            int radiosPlaying = 0;

            foreach (Device device in devices)
            {
                IRadio radio = device as IRadio;

                if (radio != null)
                {
                    Assert.IsFalse(radio.IsPlaying);
                    radio.Play();
                    Assert.IsTrue(radio.IsPlaying);
                    radiosPlaying++;
                }
            }

            Assert.AreEqual(2, radiosPlaying);
        }

        [TestMethod]
        public void AlarmClockPlaysSongRadioWhenAlarming()
        {
            AlarmClock alarm = new AlarmClock();
            alarm.Mode = AlarmClock.AlarmMode.Radio;

            alarm.TurnOnAlarm();

            Assert.IsTrue(alarm.IsAlarmOn);
            Assert.IsTrue(alarm.IsPlaying);
        }

        [TestMethod]
        public void AlarmClockJustBeepsWhenAlarming()
        {
            AlarmClock alarm = new AlarmClock();
            alarm.Mode = AlarmClock.AlarmMode.Beeping;

            alarm.TurnOnAlarm();

            Assert.IsTrue(alarm.IsAlarmOn);
            Assert.IsFalse(alarm.IsPlaying);
        }

        [TestMethod]
        public void AlarmOnDifferentTypesOfRadios ()
        {
            List<Device> devices = new List<Device>();

            devices.Add(new BoomBox());
            devices.Add(new AlarmClock());
            devices.Add(new WristWatch());

            int alarmsOn = 0;

            foreach (Device device in devices)
            {
                IClock clock = device as IClock;

                if (clock != null)
                {
                    Assert.IsFalse(clock.IsAlarmOn);
                    clock.TurnOnAlarm();
                    Assert.IsTrue(clock.IsAlarmOn);
                    alarmsOn++;
                }
            }

            Assert.AreEqual(2, alarmsOn);
        }
    }
}
