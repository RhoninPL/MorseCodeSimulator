using System;
using System.Collections.Generic;
using System.Threading;

namespace AppLibrary
{
    public class Beeper
    {
        private const int frequency = 700;
        private const int timeSpan = 400;

        public void TransmitSounds(List<Sound> sounds)
        {
            foreach (var sound in sounds)
            {
                if (sound == Sound.Dash)
                    DashBeep();

                if (sound == Sound.Dot)
                    DotBeep();
                if (sound == Sound.PauseElement)
                    PauseElement();


                if (sound == Sound.PauseCharacter)
                    PauseCharacter();

                if (sound == Sound.PauseWord)
                    PauseWord();
            }
        }

        public static void DotBeep()
        {
            Console.Beep(frequency, timeSpan * 1);
        }

        public static void DashBeep()
        {
            Console.Beep(frequency, timeSpan * 3);
        }

        public static void PauseCharacter()
        {
            Thread.Sleep(timeSpan * 3);
        }

        public static void PauseElement()
        {
            Thread.Sleep(timeSpan * 1);
        }

        public static void PauseWord()
        {
            Thread.Sleep(timeSpan * 7);
        }
    }
}