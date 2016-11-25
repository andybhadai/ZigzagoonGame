using Otter;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZigzagoonOtterEngine.Character;
using ZigzagoonOtterEngine.Characters;

namespace ZigzagoonOtterEngine
{
    class Program
    {
        static void Main(string[] args)
        {
            var game = new Game("Zigzagoon Game");

            DummyEnemy dummy = new DummyEnemy();
            dummy.X = 400.0f;
            dummy.Y = 100.0f;

            Zigzagoon zigzagoon = new Zigzagoon();
            zigzagoon.X = Game.Instance.HalfWidth;
            zigzagoon.Y = Game.Instance.HalfHeight;

            var scene = new Scene();
            scene.Add(new GroundTile());
            scene.Add(zigzagoon);
            scene.Add(dummy);

            // Start the Game.
            game.Start(scene);
        }
    }
}
