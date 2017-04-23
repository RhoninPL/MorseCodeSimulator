using AppLibrary;
using System;

namespace App
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Write your message and confirm with enter: ");
            var message = Console.ReadLine();

            Translator translator = new Translator();
            Beeper beeper = new Beeper();

            Console.WriteLine("Starting to transmit message...");
            beeper.TransmitSounds(translator.TranslateToMorse(message));
            Console.WriteLine("Finished. Press any key to exit");
            Console.ReadKey();
        }
    }
}