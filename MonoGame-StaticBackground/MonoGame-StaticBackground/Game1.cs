using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using MonoGame_StaticBackground.Core;

namespace MonoGame_StaticBackground
{
    public class Game1 : Game
    {
        private GraphicsDeviceManager _graphics;
        private SpriteBatch _spriteBatch;

        private Camera _camera;
        private Texture2D _PlayTexture;
        private Texture2D _backgorundTexture;
        private Vector2 _playerPosition;

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
            _camera = new Camera();
            _PlayTexture =Content.Load<Texture2D>("Square");
            _backgorundTexture =Content.Load<Texture2D>("background");
        }

        protected override void Update(GameTime gameTime)
        {
            if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed ||
                Keyboard.GetState().IsKeyDown(Keys.Escape))
                Exit();

            // TODO: Add your update logic here
            if (Keyboard.GetState().IsKeyDown(Keys.W))
            {
                _playerPosition.Y -= 3f;
            }

            if (Keyboard.GetState().IsKeyDown(Keys.S))
            {
                _playerPosition.Y += 3f;
            }

            if (Keyboard.GetState().IsKeyDown(Keys.A))
            {
                _playerPosition.X -= 3f;
            }

            if (Keyboard.GetState().IsKeyDown(Keys.D))
            {
                _playerPosition.X += 3f;
            }
            
            _camera.Follow(_playerPosition);
            base.Update(gameTime);
        }

        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.CornflowerBlue);
            
            _spriteBatch.Begin();
            _spriteBatch.Draw(_backgorundTexture,new Vector2(0,0),Color.White);
            _spriteBatch.End();

            // TODO: Add your drawing code here
            _spriteBatch.Begin(transformMatrix:_camera.TransForm);
            //_spriteBatch.Draw(_backgorundTexture,new Vector2(0,0),Color.White);
            _spriteBatch.Draw(_PlayTexture, _playerPosition, Color.Green);
            _spriteBatch.Draw(_PlayTexture,new Vector2(0,0),Color.Red);
            _spriteBatch.End();

            base.Draw(gameTime);
        }
    }
}