using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo
{
    public class Particle
    {
        public Texture2D Texture { get; set; }
        public Vector2 Position { get; set; }
        public Vector2 Velocity { get; set; }
        public float Angle { get; set; }
        public float AnglularVelocity { get; set; }
        public float Size { get; set; }
        public Color Colour { get; set; }
        public int LifeSpan { get; set; }

        public Particle(Texture2D texture, Vector2 position, Vector2 velocity, float angle, 
                        float angularVelocity, Color colour, float size, int lifeSpan)
        {
            Texture = texture;
            Position = position;
            Velocity = velocity;
            Angle = angle;
            AnglularVelocity = angularVelocity;
            Colour = colour;
            Size = size;
            LifeSpan = lifeSpan;
        }

        public void Update()
        {
            LifeSpan--;
            Position += Velocity;
            Angle += AnglularVelocity;
        }

        public void Draw(SpriteBatch spriteBatch)
        {
            var source = new Rectangle(0, 0, Texture.Width, Texture.Height);
            var origin = new Vector2(Texture.Width, Texture.Height);
            spriteBatch.Draw(Texture, Position, source, Colour, Angle, origin, Size, SpriteEffects.None, 0.0f);
        }

    }
}
