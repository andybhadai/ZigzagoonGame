using Otter;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZigzagoonOtterEngine.Character;

namespace ZigzagoonOtterEngine.Characters
{
    class DummyEnemy : Entity, ICharacter
    {
        public DummyEnemy() : base()
        {
            var image = Image.CreateRectangle(50);
            AddGraphic(image);
        }

        public int Attack
        {
            get
            {
                return 5;
            }
        }

        public int Defence
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
                return 5;
            }

            set
            {
                this.Health = value;
            }
        }

        public string Species
        {
            get
            {
                return "Dummy";
            }
        }

        public int Speed
        {
            get
            {
                return 20;
            }
        }

        public override void Update()
        {
            base.Update();
            this.Move();
        }

        public void Move()
        {
            //Random randomNumber = new Random();
            //int random = randomNumber.Next(0, 3);
            //Console.WriteLine(random);

            //if (random == 0)
            //{
            //    this.Y -= this.Speed;
            //}

            //if (random == 1)
            //{
            //    this.Y += this.Speed;
            //}

            //if (random == 2)
            //{
            //    this.X -= this.Speed;
            //}

            //if (random == 3)
            //{
            //    this.X += this.Speed;
            //}
        }
    }
}
