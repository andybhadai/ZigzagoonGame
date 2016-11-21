using Otter;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZigzagoonOtterEngine.Tiles
{
    class GroundTile : Entity
    {
        // The Tilemap Graphic to use for rendering tiles.
        public Tilemap Tilemap;
        // The grid size to use for the Tilemap.
        public static int GridSize = 32;
        // The current selected tile to place.
        public int CurrentTile;

        public GroundTile() : base()
            {
            // Create the Tilemap the size of the game window using the defined grid size.
            Tilemap = new Tilemap("ground.png", Game.Instance.Width, Game.Instance.Height, GridSize, GridSize);
            // Add the Tilemap to the list of Graphics to render.
            AddGraphic(Tilemap);

            // Place some tiles.
            Tilemap.SetTile(0, 0, 0);
            Tilemap.SetTile(1, 0, 0);
            Tilemap.SetTile(2, 0, 0);
        }
    }
}
