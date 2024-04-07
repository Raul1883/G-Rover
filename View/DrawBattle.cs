using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework;
using System.Collections.Generic;
using System.Runtime.ExceptionServices;
using System;
using Microsoft.Xna.Framework.Content;

namespace G_Rover
{
    public class DrawBattle
    {
        private readonly Battle Battle;
        private readonly SpriteBatch SpriteBatch;
        private readonly List<Texture2D> ImmutableInterfaceTextures = new();
        ContentManager Content;

        public InterfaceElement PositionElement;


        public DrawBattle(SpriteBatch spriteBatch, Battle battle, Texture2D plaza)
        {
            Battle = battle;
            SpriteBatch = spriteBatch;
            PositionElement = new(plaza, new Vector2(0, 100));
        }

        public void LoadContentManager(ContentManager content) => Content = content;

        public void Draw()
        {
            SpriteBatch.Begin();
            DrawImmutableInterface();
            DrawEntitys();
            

            SpriteBatch.End();
        }

        public void DrawEntitys()
        {
            //рисуем врагов
            for (var i = 3; i < 6; i++)
                DrawEntity(Battle.Map.Entitys[i]);
        }

        public void DrawEntity(IDrawableEntity entity)
        {
            if (entity == null) return;
            SpriteBatch.Draw(entity.Texture, GetVectorPositionEntity(entity), Color.White);
        }

        private void DrawImmutableInterface()
        {
            var drawList = new List<InterfaceElement>() {
            new InterfaceElement(
                Content.Load<Texture2D>("battle_interfaceConst_background"), Vector2.Zero),


             new InterfaceElement(
                Content.Load<Texture2D>("battle_interfaceConst_bottom"), new Vector2(0, 500))
        };

            foreach (var element in drawList)
                SpriteBatch.Draw(element.Texture, element.Position, element.Color);
        }

        private Vector2 GetVectorPositionEntity(IDrawableEntity entity)
        {
            if (entity == null) { throw new Exception(); }

            var positionVector = new Vector2();
            switch (entity.Position)
            {
                case Positions.BacklineRover:
                    positionVector.X = 30;
                    positionVector.Y = 300;
                    break;

                case Positions.MiddleLineRover:
                    positionVector.X = 60;
                    positionVector.Y = 300;
                    break;
                case Positions.NearLineRover:
                    positionVector.X = 90;
                    positionVector.Y = 300;
                    break;
                case Positions.NearLineEnemy:
                    positionVector.X = 150;
                    positionVector.Y = 300;
                    break;
                case Positions.MiddleLineEnemy:
                    positionVector.X = 180;
                    positionVector.Y = 300;
                    break;
                case Positions.BacklineEnemy:
                    positionVector.X = 210;
                    positionVector.Y = 300;
                    break;
            }
            return positionVector;
        }

    }
}
