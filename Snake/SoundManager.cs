using System.Media;
using Snake.Properties;

namespace Snake
{
    public static class SoundManager
    {
        public static SoundPlayer BackgroundMusicPlayer;
        public static SoundPlayer gameMusicPlayer;
        public static SoundPlayer clickSoundPlayer;

        static SoundManager()
        {
            // Initialize the sound players in the static constructor
            BackgroundMusicPlayer = new SoundPlayer(Resources.bgForm);
            clickSoundPlayer = new SoundPlayer(Resources.blipSelect);
            gameMusicPlayer = new SoundPlayer(Resources.bgGame);
        }

        public static void InitializeBackgroundMusic()
        {
            // Start playing the background music in a loop
            if (GameSettings.BackgroundMusicEnabled)
                PlayBackgroundMusic();
        }

        public static void PlayBackgroundMusic()
        {
            BackgroundMusicPlayer?.PlayLooping();
        }
        public static void StopBackgroundMusic()
        {
            BackgroundMusicPlayer?.Stop();
            BackgroundMusicPlayer?.Dispose();
        }
        public static void PlayClickSound()
        {
            clickSoundPlayer?.Play();
        }
        public static void PlayGameMusic()
        {
            gameMusicPlayer?.PlayLooping();
        }
        public static void StopGameMusic()
        {
            gameMusicPlayer?.Stop();
            gameMusicPlayer?.Dispose();
        }
    }
}
