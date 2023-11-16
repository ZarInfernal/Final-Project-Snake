namespace Snake
{
    public static class GameSettings
    {
        public static bool BackgroundMusicEnabled
        {
            get { return Properties.Settings.Default.BackgroundMusicEnabled; }
            set
            {
                Properties.Settings.Default.BackgroundMusicEnabled = value;
                Properties.Settings.Default.Save();
            }
        }

        public static bool ClickSoundEnabled
        {
            get { return Properties.Settings.Default.ClickSoundEnabled; }
            set
            {
                Properties.Settings.Default.ClickSoundEnabled = value;
                Properties.Settings.Default.Save();
            }
        }
        public static bool GameSoundEnabled
        {
            get { return Properties.Settings.Default.GameSoundEnabled; }
            set
            {
                Properties.Settings.Default.GameSoundEnabled = value;
                Properties.Settings.Default.Save();
            }
        }
    }
}
