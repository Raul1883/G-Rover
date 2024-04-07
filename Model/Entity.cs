using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace G_Rover
{
    public class Entity: IDrawableEntity
{
        string Id;
        readonly string Name;
        readonly int HealthPoint;

        public static Entity Void = new Entity() {Id="Void"};
        public Texture2D Texture { get; set; }
        public Positions Position { get; set; }
    }
}
