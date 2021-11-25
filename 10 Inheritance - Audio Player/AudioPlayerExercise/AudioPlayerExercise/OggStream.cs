using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AudioPlayerExercise
{
    public class OggStream : AudioFile
    {
        public override string Play()
        {
            return "Playing an ogg song";
        }

    }
}