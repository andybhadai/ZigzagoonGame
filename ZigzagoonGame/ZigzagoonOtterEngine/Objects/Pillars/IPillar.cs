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
        void Create(Zigzagoon zigzagoon, Vector2 Position, int id);
        int Damage { get; }
        string Material { get; }
        bool Pushable { get; }
        Vector2 Position { get; set; }
    }

    public abstract class PillarFactory
    {
        public abstract Entity Create(Zigzagoon zigzagoon, Vector2 position, int id);
    }

    public class LandPillarFactory : PillarFactory
    {
        public override Entity Create(Zigzagoon zigzagoon, Vector2 position, int id)
        {
            if(id == 1)
            {
                return new WoodenPillar(zigzagoon, position);
            }

            throw new Exception("Wrong pillar!");
        }
    }

    public class WoodenPillar : Entity, IPillar
    {
        Image Image = Image.CreateRectangle(20, 100, Color.Gold);
        BoxCollider Collider = new BoxCollider(20, 100, Tags.PushablePillar);
        Zigzagoon Zigzagoon;
        Vector2 Position = new Vector2();

        public WoodenPillar(Zigzagoon zigzagoon, Vector2 position)
        {
            this.Zigzagoon = zigzagoon;

            AddGraphic(this.Image);
            SetPosition(position.X, position.Y);
            this.Image.CenterOrigin();
            AddCollider(this.Collider);
            this.Collider.CenterOrigin();
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

        public void Create(Zigzagoon zigzagoon, Vector2 Position, int id)
        {
        }
    }
}
