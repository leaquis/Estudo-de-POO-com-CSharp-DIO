using System;
using jogo.src.Entities;

namespace jogo
{
    class Program
    {
        static void Main(string[] args)
        {
            Knight arus = new Knight("Arus", 23, "Knight", 70, 20);
            Wizard ally = new Wizard("Jenica", 23, "White Mage", 40, 60);
            Ninja ally2 = new Ninja("Naruto", 23, "Ninja", 50, 30);
            Wizard ally3 = new Wizard("Jerico", 23, "Black Mage", 40, 60);

            Console.WriteLine(arus);
            Console.WriteLine(ally);
            Console.WriteLine(ally2);
            Console.WriteLine(ally3);
            Console.WriteLine(arus.Attack());
            Console.WriteLine(ally.Attack(3));
            Console.WriteLine(ally2.Attack());
            Console.WriteLine(ally3.Attack(7));


        }
    }
}
