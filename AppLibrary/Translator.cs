using System;
using System.Collections.Generic;

namespace AppLibrary
{
    public class Translator
    {
        public List<Sound> TranslateToMorse(string message)
        {
            var morseCode = new List<Sound>();

            foreach (var characeter in message.ToUpper())
            {
                var sound = new List<Sound>();
                if (MorseCode.morseCode.TryGetValue(characeter, out sound))
                {
                    morseCode.AddRange(sound);
                    
                    morseCode.Add(characeter == ' ' ? Sound.PauseWord : Sound.PauseElement);
                }
                else
                    Console.WriteLine($"Cannot transmit: {characeter}");
            }

            return morseCode;
        }
    }
}