using Otter;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZigzagoonOtterEngine.Character;
using ZigzagoonOtterEngine.Characters;
using ZigzagoonOtterEngine.Scenes;
using ZigzagoonOtterEngine.States;

namespace ZigzagoonOtterEngine
{
    class Program
    {
        static void Main(string[] args)
        {
            ZigzagoonGameState state = new ZigzagoonGameState(new GamePlayingState());

            var game = new Game("Zigzagoon Game", 1200, 600);

            // Start the Game.
            game.Start(new MiniGame());

            state.Pause();
        }
    }
}
