using System;
using System.Collections.Generic;

namespace AudioPlayerExercise
{
    /// <summary>
    /// The AudioPlayer class can play different types of files and returns in the form of strings what it has been playing.
    /// </summary>
    public class AudioPlayer
    {
        private List<AudioFile> playlist = new List<AudioFile> { };
        public List<string> PlayAll()
        {
            List<string> list = new List<string> { };
            foreach(AudioFile file in playlist)
            {
                list.Add(file.Play());
            }
            return list;
        }

        public void AddFileToPlaylist(AudioFile file)
        {
            playlist.Add(file);
                  
        }
    }
}