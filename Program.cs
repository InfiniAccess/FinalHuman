using System;
using HumanExercise.models;

namespace HumanExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            Human sebastian = new Human("Sebastian", Strength: 4, Intelligence: 4, Health: 120);
            Human ryan = new Human("Ryan", Strength: 4, Intelligence: 4, Health: 120);
            sebastian.Attack(ryan);
        }
    }
}

