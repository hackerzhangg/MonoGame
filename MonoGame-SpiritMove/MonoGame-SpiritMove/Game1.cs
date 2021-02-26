using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace MonoGame_SpiritMove
{
    public class Game1 : Game
    {
        private GraphicsDeviceManager _graphics;
        private SpriteBatch _spriteBatch;

        private Texture2D _texture2D;
        private Vector2 _position;

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
            //No Game Box.png Yes Game Box
            _texture2D = Content.Load<Texture2D>("Game Box");
            _position = new Vector2(0, 0);
        }

        protected override void Update(GameTime gameTime)
        {
            if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed ||
                Keyboard.GetState().IsKeyDown(Keys.Escape))
                Exit();

            // TODO: Add your update logic here
            //获取图片的运动状态
            if (Keyboard.GetState().IsKeyDown(Keys.A))
            {
                //up
                _position.Y -= 1;       //_position.Y=_position.Y-1
            }
            if (Keyboard.GetState().IsKeyDown(Keys.B))
            {
                //down
                _position.Y += 1;
            }
            if (Keyboard.GetState().IsKeyDown(Keys.C))
            {
                //left
                _position.X -= 1;
            }
            if (Keyboard.GetState().IsKeyDown(Keys.D))
            {
                //right
                _position.X += 1;
            }

            base.Update(gameTime);
        }

        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.CornflowerBlue);

            // TODO: Add your drawing code here
            _spriteBatch.Begin();
            _spriteBatch.Draw(_texture2D,_position,Color.White);
            _spriteBatch.End();

            base.Draw(gameTime);
        }
    }
}