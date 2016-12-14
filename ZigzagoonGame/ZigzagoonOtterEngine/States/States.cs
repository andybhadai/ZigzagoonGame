using Otter;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static ZigzagoonOtterEngine.States.ZigzagoonGameState;

namespace ZigzagoonOtterEngine.States
{
    public class ZigzagoonGameState
    {
        private GameState _State;

        public ZigzagoonGameState(GameState _state)
        {
            this._State = _state;
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

        public interface GameState
        {
            void Unpause(ZigzagoonGameState game);
            void Pause(ZigzagoonGameState game);
        }
    }

    public class GamePlayingState : GameState
    {
        public GamePlayingState()
        {
            Console.WriteLine("The game is running!");
        }

        public void Pause(ZigzagoonGameState game)
        {
            game.CurrentState = new GamePausedState();
        }

        public void Unpause(ZigzagoonGameState game)
        {
        }
    }

    public class GamePausedState : GameState
    {
        public GamePausedState()
        {
            PauseScreen pauseScreen = new PauseScreen();
            pauseScreen.X = Game.Instance.Width;
            pauseScreen.Y = Game.Instance.Height;

            Console.WriteLine("The game is paused!");
        }

        public void Pause(ZigzagoonGameState game)
        {
        }

        public void Unpause(ZigzagoonGameState game)
        {
            game.CurrentState = new GamePlayingState();
        }
    }

    public class PauseScreen : Entity
    {
        public PauseScreen()
        {
            var image = Image.CreateRectangle(Game.Instance.Width, Color.Orange);
            AddGraphic(image);
        }
    }
}
