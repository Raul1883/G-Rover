
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;


namespace G_Rover
{
    public class MainMenuDrawer
    {
        private readonly SpriteBatch SpriteBatch;
        private readonly Texture2D Backgroud;
        private readonly Texture2D Logo;
        private readonly SpriteFont Font;


        public MainMenuDrawer(SpriteBatch spriteBatch, ContentManager content)
        {
            SpriteBatch = spriteBatch;
            Backgroud = content.Load<Texture2D>("main_menu_background");
            Logo = content.Load<Texture2D>("logo_160px");
            Font = content.Load<SpriteFont>("Better_VCR_24");
        }

        public void Draw(MainMenu mainMenu)
        {
            SpriteBatch.Begin();
            SpriteBatch.Draw(Backgroud, Vector2.Zero, Color.White);
            SpriteBatch.Draw(Logo, new Vector2(106, 23), Color.White);

            //var lines = new string[] { "New game", "Collection", "Settings", "Exit" };

            //InterfaceDrawer.DrawColumn(SpriteBatch, Font, new Vector2(106,216), 77, lines );



            foreach (var button in mainMenu.GetButtons())
                SpriteBatch.DrawString(Font, button.Text, button.Position, Color.White);


            SpriteBatch.End();
        }


        public void DrawButton(TextButton button)
        {
            SpriteBatch.DrawString(Font, button.Text, button.Position, Color.White);
        }
    }
}
