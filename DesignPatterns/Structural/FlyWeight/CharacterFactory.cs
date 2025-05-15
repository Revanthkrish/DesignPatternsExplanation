using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Structural.FlyWeight
{
    public class CharacterFactory
    {
        private Dictionary<char, ICharacter> _characters = new Dictionary<char, ICharacter>();

        public ICharacter GetCharacter(char key)
        {
            if (_characters.ContainsKey(key))
            {
                return _characters[key]; // Return cached object
            }

            ICharacter character = key switch
            {
                'A' => new CharacterA(),
                'B' => new CharacterB(),
                _ => throw new NotImplementedException($"Character '{key}' not implemented")
            };

            _characters[key] = character;
            return character;
        }
    }
}
