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
            if (Input.KeyDown(Key.W) || Input.KeyDown(Key.Up))
            {
                this.Y -= this.Speed;
            }

            if (Input.KeyDown(Key.S) || Input.KeyDown(Key.Down))
            {
                this.Y += this.Speed;
            }

            if (Input.KeyDown(Key.A) || Input.KeyDown(Key.Left))
            {
                this.X -= this.Speed;
            }

            if (Input.KeyDown(Key.D) || Input.KeyDown(Key.Right))
            {
                this.X += this.Speed;
            }
        }
    }
}
