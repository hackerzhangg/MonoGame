using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace MonoGame_SpiritMove
{
    public class Sprite
    {
        private Texture2D _texture2D;
        private Vector2 Position;

        private float Speed = 2f;

        public Sprite(Texture2D _texture)
        {
            this._texture2D = _texture;
        }

        public void Update()
        {
            if (Keyboard.GetState().IsKeyDown(Keys.A))
            {
                Position.Y -= Speed;
            }
            if (Keyboard.GetState().IsKeyDown(Keys.D))
            {
                Position.Y += Speed;
            }
            if (Keyboard.GetState().IsKeyDown(Keys.W))
            {
                Position.X -= Speed;
            }
            if (Keyboard.GetState().IsKeyDown(Keys.S))
            {
                Position.X += Speed;
            }
            
        }

        public void Draw(SpriteBatch spriteBatch)
        { 
            spriteBatch.Draw(_texture2D,Position,Color.Aqua);   
        }
    }
}