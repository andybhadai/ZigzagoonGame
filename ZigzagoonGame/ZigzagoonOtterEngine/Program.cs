using Otter;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZigzagoonOtterEngine.Character;
using ZigzagoonOtterEngine.Characters;
using ZigzagoonOtterEngine.Scenes;

namespace ZigzagoonOtterEngine
{
    class Program
    {
        static void Main(string[] args)
        {
            var game = new Game("Zigzagoon Game", 1200, 600);

            // Start the Game.
            game.Start(new HomeScene());
        }
    }
}
