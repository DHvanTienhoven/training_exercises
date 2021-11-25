using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AudioPlayerExercise
{
    class Mp3File: AudioFile
    {
        public override string Play()
        {
            return "Playing an mp3 song";
        }
    }
}
