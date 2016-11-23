using Otter;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZigzagoonOtterEngine.Character;

namespace ZigzagoonOtterEngine
{
    class Program
    {
        static void Main(string[] args)
        {
            var game = new Game("Zigzagoon Game");

            Zigzagoon zigzagoon = new Zigzagoon();
            zigzagoon.X = Game.Instance.HalfWidth;
            zigzagoon.Y = Game.Instance.HalfHeight;

            var scene = new Scene();
            scene.Add(new GroundTile());
            scene.Add(zigzagoon);

            // Start the Game.
            game.Start(scene);
        }
    }
}
