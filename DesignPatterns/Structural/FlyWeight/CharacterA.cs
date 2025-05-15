using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Structural.FlyWeight
{
    public class CharacterA : ICharacter
    {
        public void Display(int pointSize)
        {
            Console.WriteLine($"Character: A, Point Size: {pointSize}");
        }
    }

    public class CharacterB : ICharacter
    {
        public void Display(int pointSize)
        {
            Console.WriteLine($"Character: B, Point Size: {pointSize}");
        }
    }
}
