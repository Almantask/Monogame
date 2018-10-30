using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo
{
    public class ParticleEngine
    {
        public Vector2 StartLocation { get; set; }

        private Random random;
        private List<Particle> particles;
        private List<Texture2D> textures;

        private int amount = 50;

        public ParticleEngine(List<Texture2D> textures, Vector2 location)
        {
            StartLocation = location;
            this.textures = textures;
            particles = new List<Particle>();
            random = new Random();
        }

        public void Update()
        {
            for (int index = 0; index < amount; index++)
            {
                particles.Add(GenerateParticle());
            }

            for (int index = 0; index < particles.Count; index++)
            {
                particles[index].Update();

                if (particles[index].LifeSpan <= 0)
                {
                    particles.RemoveAt(index);
                    index--;
                }
            }
        }

        private Particle GenerateParticle()
        {
            var texture = textures[random.Next(textures.Count)];
            var position = StartLocation;
            var velocity = new Vector2(10.0f * (float)(random.NextDouble()), 10.0f * (float)(random.NextDouble()));
            var angle = 0.0f;
            var angularVelocity = 10.0f * (float)(random.NextDouble());
            var colour = new Color((float)random.NextDouble(), (float)random.NextDouble(), (float)random.NextDouble());
            var size = (float)random.NextDouble();
            var lifeSpan = 20 + random.Next(40);

            return new Particle(texture, position, velocity, angle, angularVelocity, colour, size, lifeSpan);

        }

        public void Draw(SpriteBatch spriteBatch)
        {
            spriteBatch.Begin();

            for (int index = 0; index < particles.Count; index++)
            {
                particles[index].Draw(spriteBatch);
            }

            spriteBatch.End();

        }

    }
}
