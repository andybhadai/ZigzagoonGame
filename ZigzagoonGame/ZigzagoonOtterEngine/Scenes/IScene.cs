using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZigzagoonOtterEngine.Scenes
{
    public interface IScene
    {
        void LoadScene();
        void AddEntities();
        void AddGraphics();
    }
}
