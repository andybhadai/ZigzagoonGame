using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sandbox.Factory
{
    public interface Tile
    {
        void Create(int id);
        bool Swimmable { get; }
        bool Walkable { get; }
        int Damage { get; }
    }

    public abstract class TileFactory
    {
        public abstract Tile Create(int id);
    }

    class LandTileFactory : TileFactory
    {
        public override Tile Create(int id)
        {
            if(id == 1)
            {
                return new GrassTile();
            }

            throw new Exception("Wrong input!");
        }
    }

    class GrassTile : Tile
    {
        public int Damage
        {
            get
            {
                return 0;
            }
        }

        public bool Swimmable
        {
            get
            {
                return false;
            }
        }

        public bool Walkable
        {
            get
            {
                return true;
            }
        }

        public void Create(int id)
        {
        }
    }
}
