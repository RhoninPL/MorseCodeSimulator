using AppLibrary;
using System;

namespace App
{
    class Program
    {
        static void Main(string[] args)
        {
            Translator translator = new Translator();
            Beeper beeper = new Beeper();
            beeper.TransmitSounds(translator.TranslateToMorse("S O S"));
            Console.ReadKey();
        }
    }
}