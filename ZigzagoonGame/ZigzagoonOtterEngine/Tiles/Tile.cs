using Otter;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZigzagoonOtterEngine.Tiles
{
    class Tile : Entity
    {
        public Tilemap Tilemap;
        public static int GridSize = 32;
        public int CurrentTile;

        public Tile() : base()
        {
            this.Tilemap = new Tilemap("tiles.png", Game.Instance.Width, Game.Instance.Height, GridSize, GridSize);
            AddGraphic(this.Tilemap);

            this.Tilemap.SetTile(0, 0, 0);
            this.Tilemap.SetTile(1, 0, 0);
            this.Tilemap.SetTile(2, 0, 0);
        }
    }
}
