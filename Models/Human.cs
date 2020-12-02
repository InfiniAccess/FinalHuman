using System;

namespace HumanExercise.models


{
    public class Human
    {
        public string Name;
        public int Strength;
        public int Intelligence;
        public int Dexterity;
        private int Health;

        public int health
        {
            get { return Health; }
        }

        public Human(string name, int Strength = 3, int Intelligence = 3, int Dexterity = 3, int Health = 100)
        {
            Name = name;
            this.Strength = Strength;
            this.Intelligence = Intelligence;
            this.Dexterity = Dexterity;
            this.Health = Health;
        }

        public int Attack(Human target)
        {
            target.Health = target.Health - (Strength * 5);
            Console.Write($"{target.Name}'s health is now {target.Health}.");
            return target.Health;
        }

        public void PrintInfo()
        {
            Console.WriteLine($"Name: {Name}\nStrength: {Strength}\nIntelligence: {Intelligence}\nDexterity: {Dexterity}\nHealth: {Health}");
        }

    }
}