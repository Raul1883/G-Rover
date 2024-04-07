using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace G_Rover
{
    public class MainMenu : IState
    {
        private readonly TextButton NewGameButton;
        private readonly TextButton CollectionButton;
        private readonly TextButton SettingsButton;
        private readonly TextButton ExitButton;
        public MainMenu()
        {

            NewGameButton = new TextButton("1", new Vector2(106, 216), 180, 24, "Новая игра");
            CollectionButton = new TextButton("1", new Vector2(119, 304), 162, 24, "Коллекция");
            SettingsButton = new TextButton("1", new Vector2(119, 392), 162, 24, "Настройки");
            ExitButton = new TextButton("1", new Vector2(155, 480), 90, 24, "Выход");

        }

        public TextButton[] GetButtons() =>
             new TextButton[] { NewGameButton, CollectionButton, SettingsButton, ExitButton };

        public void Update(MouseState mouseState)
        {
            foreach (var button in GetButtons())
            {
                button.Update(mouseState);
            }
        }
    }
}
