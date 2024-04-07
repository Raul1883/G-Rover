using Microsoft.Xna.Framework.Graphics;
using System;
using Microsoft.Xna.Framework;

namespace G_Rover
{
    public class InterfaceElement : IDrawable
    {
        public Texture2D Texture { get; set; }
        public Vector2 Position { get; set; }
        public Color Color { get; private set; }
        public int margin = 20;
        public InterfaceElement(Texture2D texture, Vector2 position)
        {
            Texture = texture;
            Position = position;
            Color = Color.White;
        }
        public InterfaceElement(Texture2D texture, Vector2 position, Color color)
        {
            Texture = texture;
            Position = position;
            Color = color;
        }
    }
}
