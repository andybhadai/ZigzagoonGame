using Otter;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZigzagoonOtterEngine.Tiles
{
    public interface ITile
    {
        string BackgroundImage { get; }
        Vector2 Position { get; }
        void GenerateTiles();

    }
}
