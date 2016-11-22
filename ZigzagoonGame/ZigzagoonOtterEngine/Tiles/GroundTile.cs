using Otter;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZigzagoonOtterEngine.Tiles;

namespace ZigzagoonOtterEngine
{
    class GroundTile : Entity, ITile
    {
        public Tilemap Tilemap;
        public static int GridSize = 32;

        public string BackgroundImage
        {
            get
            {
                return "ground.png";
            }
        }

        public GroundTile() : base()
        {
            Console.WriteLine(this.BackgroundImage);
            Tilemap = new Tilemap(this.BackgroundImage, Game.Instance.Width, Game.Instance.Height, GridSize, GridSize);
            AddGraphic(Tilemap);
            this.GenerateTiles();
        }

        public override void Update()
        {
            base.Update();
        }

        public void GenerateTiles()
        {
            int count = 0;

            for(int i = 0; i < Game.Instance.Width / 32; i++)
            {
                count++;
                Tilemap.SetTile(i, 0, 0);
                
                // Convert the index to float
                this.Position = new Vector2((float) i, 0);
            }
        }
    }
}
