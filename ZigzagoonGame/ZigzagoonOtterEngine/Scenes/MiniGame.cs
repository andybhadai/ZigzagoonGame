using Otter;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZigzagoonOtterEngine.Character;
using ZigzagoonOtterEngine.Objects.Pillars;

namespace ZigzagoonOtterEngine.Scenes
{
    class MiniGame : Scene, IScene
    {
        public MiniGame(int width = 0, int height = 0) : base(width, height)
        {
            this.LoadScene();
        }

        public void AddEntities()
        {
            Zigzagoon zigzagoon = new Zigzagoon();
            zigzagoon.X = Game.Instance.HalfWidth;
            zigzagoon.Y = Game.Instance.HalfHeight;
            this.Add(zigzagoon);

            LandPillarFactory pillarFactory = new LandPillarFactory();

            for(int i = 0; i < 5; i++)
            {
                var woodenPillar = pillarFactory.Create(zigzagoon, new Vector2((float)i * 10, (float)i * 10), 1);
                this.Add(woodenPillar);
            }
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
