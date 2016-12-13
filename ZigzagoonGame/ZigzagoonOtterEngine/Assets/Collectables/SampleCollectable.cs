using Otter;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ZigzagoonOtterEngine.Character;
using ZigzagoonOtterEngine.Characters;

namespace ZigzagoonOtterEngine.Assets.Collectables
{
    class SampleCollectable : Entity
    {
        Image Image = Image.CreateCircle(5, Color.Green);
        CircleCollider Collider = new CircleCollider(5, Tags.Collectable);
         
        public SampleCollectable(float x = 0, float y = 0) : base(x, y)
        {
            AddGraphic(this.Image);
            this.Image.CenterOrigin();
            AddCollider(this.Collider);
            this.Collider.CenterOrigin();
        }

        public override void Update()
        {
            base.Update();

            if(this.Collider.Overlap(this.X, this.Y, Tags.Player))
            {
                RemoveSelf();
                Zigzagoon.Score += 10;
            }
        }
    }
}
