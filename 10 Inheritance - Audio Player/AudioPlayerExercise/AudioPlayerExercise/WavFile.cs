using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AudioPlayerExercise
{
    class WavFile : AudioFile
    {
        public override string Play()
        {
            return "Playing a wav song";
        }
    }
}
