using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AudioPlayerExercise
{

    [TestClass]
    public class AudioPlayerTest
    {
        [TestMethod]
        public void PlayDifferentTypesOfSongs()
        {
            AudioPlayer player = new AudioPlayer();
            player.AddFileToPlaylist(new WavFile());
            player.AddFileToPlaylist(new Mp3File());
            player.AddFileToPlaylist(new Mp3File());
            player.AddFileToPlaylist(new OggStream());

            List<string> songsPlayed = player.PlayAll();

            CollectionAssert.AreEquivalent(new List<string>(){"Playing a wav song", "Playing an mp3 song", "Playing an mp3 song", "Playing an ogg song" }, songsPlayed);
        }
    }
}
