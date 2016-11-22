using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZigzagoonOtterEngine.Character
{
    class Zigzagoon : ICharacter
    {
        public int Attack
        {
            get
            {
                return 15;
            }
        }

        public int Defence
        {
            get
            {
                return 35;
            }
        }

        int Health
        {
            get
            {
                return 40;
            }
        }

        public string Species
        {
            get
            {
                return "Zigzagoon";
            }
        }

        int ICharacter.Health
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public int Speed
        {
            get
            {
                throw new NotImplementedException();
            }
        }

        public int ID
        {
            get
            {
                return 1;
            }
        }
    }
}
