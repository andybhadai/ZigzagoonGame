using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sandbox.State
{
    public class Game
    {
        private GameState _State;

        public Game(GameState state)
        {
            this._State = state;
        }

        public void Unpause()
        {
            this._State.Unpause(this);
        }

        public void Pause()
        {
            this._State.Pause(this);
        }

        public GameState CurrentState
        {
            get
            {
                return this._State;
            }

            set
            {
                this._State = value;
            }
        }
    }

    public interface GameState
    {
        void Unpause(Game game);
        void Pause(Game game);
    }

    public class GamePlayingState : GameState
    {
        public GamePlayingState()
        {
            Console.WriteLine("Game is running!");
        }

        public void Pause(Game game)
        {
            game.CurrentState = new GamePausedState();
        }

        public void Unpause(Game game)
        {
            Console.WriteLine("No effect!");
        }
    }

    public class GamePausedState : GameState
    {
        public GamePausedState()
        {
            Console.WriteLine("Game is paused!");
        }

        public void Pause(Game game)
        {
            Console.WriteLine("No effect!");
        }

        public void Unpause(Game game)
        {
            game.CurrentState = new GamePlayingState();
        }
    }
}
