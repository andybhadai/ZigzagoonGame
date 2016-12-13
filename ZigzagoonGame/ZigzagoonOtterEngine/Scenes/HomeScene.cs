using Otter;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZigzagoonOtterEngine.Assets.Collectables;
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

            for (int i = 0; i < 50; i++)
            {
                // Check out the Rand class for random generation!
                var x = Rand.Float(Game.Instance.Width);
                var y = Rand.Float(Game.Instance.Height);
                // Add the Collectable at the randomized position.
                this.Add(new SampleCollectable(x, y));
            }

            this.Add(zigzagoon);
            this.Add(dummy);
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
