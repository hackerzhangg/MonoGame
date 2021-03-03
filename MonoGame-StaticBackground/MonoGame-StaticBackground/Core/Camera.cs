using Microsoft.Xna.Framework;

namespace MonoGame_StaticBackground.Core
{
    public class Camera
    {
        public Matrix TransForm { get; set; }

        public void Follow(Vector2 vector2)
        {
            var position = Matrix.CreateTranslation(vector2.X, vector2.Y, 0);

            var offset = Matrix.CreateTranslation(400, 240, 0);

            TransForm = position * offset;
        }
    }
}