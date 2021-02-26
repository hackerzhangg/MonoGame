using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace MonoGame_SpiritEnterPackaging
{
    public class Sprite
    {

        public Texture2D Texture2D;
        public Vector2 Position;
        public float Speed=2f;
        public Input Input;

        public Sprite(Texture2D texture2D)
        {
            Texture2D = texture2D;
        }

        public void update()
        {
            move();
        }

        public void move()
        {
            if (Input ==null)
                return;

            if (Keyboard.GetState().IsKeyDown(Input.Right))
            {
                Position.X += Speed;
            }
            
            if (Keyboard.GetState().IsKeyDown(Input.Left))
            {
                Position.X -= Speed;
            }
            
            if (Keyboard.GetState().IsKeyDown(Input.Up))
            {
                Position.Y -= Speed;
            }
            
            if (Keyboard.GetState().IsKeyDown(Input.Down))
            {
                Position.Y += Speed;
            }
        }

        public void Draw(SpriteBatch spriteBatch)
        {
            spriteBatch.Draw(Texture2D,Position,Color.Aquamarine);
        }
    }
}