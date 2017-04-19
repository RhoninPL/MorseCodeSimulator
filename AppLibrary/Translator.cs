using System.Collections.Generic;

namespace AppLibrary
{
    public class Translator
    {
        public List<Sound> TranslateToMorse(string v)
        {
            return new List<Sound>()
            {
                Sound.Dot, Sound.Dot, Sound.Dot, Sound.PauseCharacter,
                Sound.Dash,Sound.Dash,Sound.Dash,Sound.PauseCharacter,
                Sound.Dot, Sound.Dot, Sound.Dot, Sound.PauseCharacter,
            };
        }
    }
}