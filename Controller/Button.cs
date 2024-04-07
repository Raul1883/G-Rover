using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
namespace G_Rover
{

    public class Button
    {
        //доделать капсуляцию отрисовки
        public Vector2 Position { get; set; }
        public int Height;
        public int Width;
        public delegate void Click();
        public event Click ClickEvent;
        public Color Color = Color.White;
        private bool IsOnButton(MouseState mouse)
        {
            var x = mouse.X;
            var y = mouse.Y;
            if (x >= Position.X && x <= Position.X + Width &&
            y >= Position.Y && y <= Position.Y + Height)
                return true;
            return false;
        }

        private bool IsButtonPressed(MouseState mouse) =>
            IsOnButton(mouse) && mouse.LeftButton == ButtonState.Pressed;

        public void Update(MouseState mouse)
        {
            if (IsButtonPressed(mouse))
                ClickEvent.Invoke();
        }


    }
    public class ImageButton : Button
    {
        public readonly string Id;
        public Texture2D Texture { get; set; }

        public ImageButton(string id, Vector2 position, Texture2D texture)
        {
            Id = id;
            Position = position;
            Height = texture.Height;
            Width = texture.Width;
            Texture = texture;
        }
    }

    public class TextButton : Button
    {
        public string Text { get; }

        public readonly string Id;

        public TextButton(string id, Vector2 position, int heigth, int width, string text)
        {
            Id = id;
            Position = position;
            Height = heigth;
            Width = width;
            Text = text;
        }
    }
}
