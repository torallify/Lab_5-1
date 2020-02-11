using System;
using System.Collections.Generic;
using System.Text;

namespace Lab_5_1
{
    class MagicUsingCharacter : GameCharacter
    {
        private int magicalEnergy;

        public int MagicalEnergy { get => magicalEnergy; set => magicalEnergy = value; }
        public MagicUsingCharacter(string name, int strength, int intelligence, int magicalEnergy) : base(name, strength, intelligence)
        {
            this.magicalEnergy = magicalEnergy;
        }

        public override string Play()
        {
            return $"{Name} - (intelligence: {Intelligence} , strength: {Strength}, magical energy: { magicalEnergy})";
            
        }
    }
}
