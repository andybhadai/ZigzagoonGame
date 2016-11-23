using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Otter;

namespace ZigzagoonOtterEngine.Character
{
    public class Zigzagoon : Entity, ICharacter
    {
        
        public Zigzagoon() : base()
        {
            var image = Image.CreateRectangle(32);
            AddGraphic(image);
        }

        public int Attack
        {
            get
            {
                return 15;
            }
        }

        public int Defence
        {
            get
            {
                return 35;
            }
        }

        public string Species
        {
            get
            {
                return "Zigzagoon";
            }
        }

        public int Speed
        {
            get
            {
                return 10;
            }
        }

        public int ID
        {
            get
            {
                return 1;
            }
        }

        public int Health
        {
            get
            {
                return 50;
            }
            set
            {
                this.Health = value;
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

        public override void Update()
        {
            base.Update();
            this.Move();
        }

        public void Move()
        {
            if (Input.KeyDown(Key.W))
            {
                this.Y -= this.Speed;
            }

            if (Input.KeyDown(Key.S))
            {
                this.Y += this.Speed;
            }

            if (Input.KeyDown(Key.A))
            {
                this.X -= this.Speed;
            }

            if (Input.KeyDown(Key.D))
            {
                this.X += this.Speed;
            }
        }
    }
}
