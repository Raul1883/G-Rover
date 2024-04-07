using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace G_Rover
{
    public class Rover : IDrawableEntity
    {
        public Positions Position { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public Texture2D Texture { get; set; }
        public Rover(Positions position, Texture2D texture)
        {
            Position = position;
            Texture = texture;
        }
    }
}
