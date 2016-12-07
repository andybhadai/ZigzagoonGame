using Otter;
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
        Vector2 Position { get; set; }
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

            if(id == 2)
            {
                return new MudTile();
            }

            if(id == 3)
            {
                return new LavaTile();
            }

            throw new Exception("Wrong input!");
        }
    }

    class SeaTileFactory : TileFactory
    {
        public override Tile Create(int id)
        {
            if(id == 1)
            {
                return new RiverTile();
            }

            if(id == 2)
            {
                return new DeepSeaTile();
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

        public Vector2 Position
        {
            get
            {
                return new Vector2(0.0f, 0.0f);
            }

            set
            {
                this.Position = value;
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

    class MudTile : Tile
    {
        public int Damage
        {
            get
            {
                return 0;
            }
        }

        public Vector2 Position
        {
            get
            {
                throw new NotImplementedException();
            }

            set
            {
                throw new NotImplementedException();
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

    class RiverTile : Tile
    {
        public int Damage
        {
            get
            {
                return 1;
            }
        }

        public Vector2 Position
        {
            get
            {
                throw new NotImplementedException();
            }

            set
            {
                throw new NotImplementedException();
            }
        }

        public bool Swimmable
        {
            get
            {
                return true;
            }
        }

        public bool Walkable
        {
            get
            {
                return false;
            }
        }

        public void Create(int id)
        {
        }
    }

    class DeepSeaTile : Tile
    {
        public int Damage
        {
            get
            {
                return 4;
            }
        }

        public Vector2 Position
        {
            get
            {
                throw new NotImplementedException();
            }

            set
            {
                throw new NotImplementedException();
            }
        }

        public bool Swimmable
        {
            get
            {
                return true;
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
            throw new NotImplementedException();
        }
    }

    class LavaTile : Tile
    {
        public int Damage
        {
            get
            {
                return 10;
            }
        }

        public Vector2 Position
        {
            get
            {
                throw new NotImplementedException();
            }

            set
            {
                throw new NotImplementedException();
            }
        }

        public bool Swimmable
        {
            get
            {
                return true;
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
