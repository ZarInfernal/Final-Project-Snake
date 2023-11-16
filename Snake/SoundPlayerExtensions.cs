using System;
using System.Collections.Generic;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    public static class SoundPlayerExtensions
    {
        public static bool IsPlaying(this SoundPlayer soundPlayer)
        {
            try
            {
                // Attempt to play a short silent sound to check if the player is working
                soundPlayer.Play();
                soundPlayer.Stop();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}
