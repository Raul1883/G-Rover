using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace G_Rover
{
    public static class TextureManager 
    {
        private const string ContentPath = "C:\\Users\\usuov\\source\\repos\\G-Rover\\View\\Content\\bin\\DesktopGL\\Content\\";

        private static readonly List<InterfaceElement> BattleImmutableInterface = new();



        public static void LoadContent(ContentManager content)
        {
            var list = new List<InterfaceElement>();

        }

        private static List<InterfaceElement> LoadBattleInteface(ContentManager content)
        {
            var list = new List<Texture2D>();
            list.Add(content.Load<Texture2D>(""));


            return default;
        }
    }
}
