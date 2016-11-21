using Otter;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZigzagoonOtterEngine
{
    class Tile : Entity
    {
        public Tilemap Tilemap;
        public static int GridSize = 32;
        public int CurrentTile;

        public Tile(float x = 0, float y = 0, Graphic graphic = null, Collider collider = null, string name = "") : base(x, y, graphic, collider, name)
        {
            this.Tilemap = new Tilemap("ground.png", Game.Instance.Width, Game.Instance.Height, GridSize, GridSize);
            this.AddGraphic(Tilemap);
            this.Tilemap.SetTile(0, 0, 0);
            this.Tilemap.SetTile(1, 0, 0);
            this.Tilemap.SetTile(2, 0, 0);
            this.Tilemap.SetTile(3, 0, 0);
            this.Tilemap.SetTile(4, 0, 0);
        }

        public override void Update()
        {
            base.Update();
            Console.WriteLine("Updating...");

            var gridX = (int)Util.SnapToGrid(Input.MouseX, GridSize) / GridSize;
            var gridY = (int)Util.SnapToGrid(Input.MouseY, GridSize) / GridSize;
        }
    }
}
