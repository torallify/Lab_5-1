using System;
using System.Collections.Generic;

namespace Lab_5_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to World of Dev.Buildcraft!\n");
            List<GameCharacter> characters = new List<GameCharacter>();

            characters.Add(new Warrior("Tnarg the Barbarian", 16, 9, "Axe"));
            characters.Add(new Warrior("Kincaid the Fighter", 15, 16, "Longsword"));
            characters.Add(new Warrior("Grant the Viking",15, 16, "Spear"));
            characters.Add(new Wizard("Lady Witherell the Wizard", 11, 18, 10, 5));
            characters.Add(new Wizard("Pearl the Magician", 12, 17, 9, 4));

            foreach (GameCharacter playa in characters)
            {
                Console.WriteLine(playa.Play());
            }
        }
    }
}
