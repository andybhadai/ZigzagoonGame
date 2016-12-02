using Otter;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZigzagoonOtterEngine.Character;
using ZigzagoonOtterEngine.Characters;
using ZigzagoonOtterEngine.Tiles;

namespace ZigzagoonOtterEngine.Scenes
{
    class HomeScene : Scene, IScene
    {
        public HomeScene(int width = 0, int height = 0) : base(width, height)
        {
            this.LoadScene();
        }

        public void AddEntities()
        {
            Zigzagoon zigzagoon = new Zigzagoon();
            zigzagoon.X = Game.Instance.HalfWidth;
            zigzagoon.Y = Game.Instance.HalfHeight;

            DummyEnemy dummy = new DummyEnemy();
            dummy.X = 400.0f;
            dummy.Y = 100.0f;

            this.Add(zigzagoon);
            this.Add(dummy);
            this.Add(new Tile());
        }

        public void AddGraphics()
        {
        }

        public void LoadScene()
        {
            this.AddEntities();
            this.AddGraphics();
        }
    }
}
