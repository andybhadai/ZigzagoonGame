using Otter;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZigzagoonOtterEngine.Scenes
{
    class JungleScene : Scene, IScene
    {
        public void AddEntities()
        {
            throw new NotImplementedException();
        }

        public void AddGraphics()
        {
            AddGraphic(Image.CreateRectangle(Game.Instance.Width, Game.Instance.Height, Color.Red));
        }

        public void LoadScene()
        {
            throw new NotImplementedException();
        }
    }
}
