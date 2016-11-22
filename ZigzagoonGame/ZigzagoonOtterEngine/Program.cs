using Otter;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZigzagoonOtterEngine
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create a Game.
            var game = new Game("Zigzagoon Game");

            // Create a Scene.
            var scene = new Scene();

            // Add the Tiles Entity to the Scene.
            scene.Add(new GroundTile());

            // Set the mouse visibility to true for this example.
            game.MouseVisible = true;

            // Start the Game.
            game.Start(scene);
        }
    }
}
