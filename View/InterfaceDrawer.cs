using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;

using System.Linq;
using System.Xml.Linq;


namespace G_Rover
{
    public static class InterfaceDrawer
    {
        public static void DrawRow(SpriteBatch _spriteBatch, params InterfaceElement[] elements)
        {
            var pointer = elements.First().Position.X;
            var color = elements.First().Color;

            foreach (var element in elements)
            {
                var shiftVector = new Vector2(pointer, 0);
                _spriteBatch.Draw(element.Texture, element.Position + shiftVector, color);
                pointer += element.Texture.Width + element.margin;
            }
        }

        public static void DrawRow(SpriteBatch spriteBatch, 
            Color color, SpriteFont font, int margin, TextButton[] buttons)
        {
            var pointer = buttons.First().Position;

            foreach (var b in buttons)
            {
                
                spriteBatch.DrawString(font, b.Text, b.Position, color);
                pointer.X += b.Width + margin;
            }
        }

        public static void DrawColumn(SpriteBatch _spriteBatch, params InterfaceElement[] elements)
        {
            var pointer = elements.First().Position.Y;
            var color = elements.First().Color;

            foreach (var element in elements)
            {
                var shiftVector = new Vector2(0, pointer);
                _spriteBatch.Draw(element.Texture, element.Position + shiftVector, color);
                pointer += element.Texture.Height + element.margin;
            }
        }

        public static void DrawColumn(SpriteBatch spriteBatch,
    Color color, SpriteFont font, int margin, params TextButton[] buttons)
        {
            var pointer = buttons.First().Position.Y;

            foreach (var b in buttons)
            {
                var shiftVector = new Vector2(0, pointer);
                spriteBatch.DrawString(font, b.Text, shiftVector, color);
                pointer += b.Height + margin;
            }
        }

    }
}
