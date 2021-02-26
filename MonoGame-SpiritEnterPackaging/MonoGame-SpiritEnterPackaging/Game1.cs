using System.Collections.Generic;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace MonoGame_SpiritEnterPackaging
{
    public class Game1 : Game
    {
        private GraphicsDeviceManager _graphics;
        private SpriteBatch _spriteBatch;

        private List<Sprite> _sprites;

        private Input Input;

        public Game1()
        {
            _graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
            IsMouseVisible = true;
        }

        protected override void Initialize()
        {
            // TODO: Add your initialization logic here

            base.Initialize();
        }

        protected override void LoadContent()
        {
            _spriteBatch = new SpriteBatch(GraphicsDevice);

            // TODO: use this.Content to load your game content here
            var texture = Content.Load<Texture2D>("Game Box");

            _sprites = new List<Sprite>()
            {
                new Sprite(texture)
                {
                    Position = new Vector2(100, 200),
                    Input = new Input()
                    {
                        Up = Keys.W,
                        Down = Keys.S,
                        Left = Keys.A,
                        Right = Keys.D,
                    }
                },

                new Sprite(texture)
                    {
                    Position = new Vector2(200, 200),
                    Input = new Input()
                    {
                        Up = Keys.Up,
                        Down = Keys.Down,
                        Left = Keys.Left,
                        Right = Keys.Right,
                    }
                }   
            };
        }

        protected override void Update(GameTime gameTime)
        {
            if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed ||
                Keyboard.GetState().IsKeyDown(Keys.Escape))
                Exit();

            // TODO: Add your update logic here
            foreach (var sprites in _sprites)
            {
                sprites.update();
            }

            base.Update(gameTime);
        }

        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.CornflowerBlue);

            // TODO: Add your drawing code here
            _spriteBatch.Begin();
            foreach (var sprites in _sprites)
            {
                sprites.Draw(_spriteBatch);
            }
            _spriteBatch.End();

            base.Draw(gameTime);
        }
    }
}