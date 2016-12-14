using Otter;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZigzagoonOtterEngine.Character;
using ZigzagoonOtterEngine.Characters;

namespace ZigzagoonOtterEngine.Objects.Pillars
{
    public interface IPillar
    {
        void Create(Zigzagoon zigzagoon, int id);
        int Damage { get; }
        string Material { get; }
        bool Pushable { get; }
        Vector2 Position { get; set; }
    }

    public abstract class PillarFactory : Entity
    {
        public abstract IPillar Create(Zigzagoon zigzagoon, int id);
    }

    public class LandPillarFactory : PillarFactory
    {
        public override IPillar Create(Zigzagoon zigzagoon, int id)
        {
            if(id == 1)
            {
                return new WoodenPillar(zigzagoon);
            }

            if(id == 2)
            {
                return new IronPillar();
            }

            throw new Exception("Wrong pillar!");
        }
    }

    public class WoodenPillar : Entity, IPillar
    {
        Image Image = Image.CreateRectangle(20, 100, Color.Gold);
        BoxCollider Collider = new BoxCollider(20, 100, Tags.PushablePillar);
        Zigzagoon Zigzagoon;
        
        public WoodenPillar(Zigzagoon zigzagoon, Vector2 position)
        {
            this.Zigzagoon = zigzagoon;

            AddGraphic(this.Image);
            this.Image.CenterOrigin();
            AddCollider(this.Collider);
            this.Collider.CenterOrigin();

            this.X = position.X;
            this.Y = position.Y;
        }

        public override void Update()
        {
            base.Update();

            if(this.Collider.Overlap(this.X, this.Y, Tags.Player))
            {
                this.Zigzagoon.Y -= this.Zigzagoon.Speed - 1;
                this.Y += this.Zigzagoon.Speed -1;
            }
        }

        public int Damage
        {
            get
            {
                return 0;
            }
        }

        public string Material
        {
            get
            {
                return "Wood";
            }
        }

        public bool Pushable
        {
            get
            {
                return true;
            }
        }

        public void Create(Zigzagoon zigzagoon, int id)
        {
            throw new NotImplementedException();
        }
    }

    public class IronPillar : IPillar
    {
        public int Damage
        {
            get
            {
                return 0;
            }
        }

        public string Material
        {
            get
            {
                return "Iron";
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

        public bool Pushable
        {
            get
            {
                return true;
            }
        }

        public void Create(Zigzagoon zigzagoon, int id)
        {
            throw new NotImplementedException();
        }
    }
}
