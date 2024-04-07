using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using System;
using System.ComponentModel.Design;

namespace G_Rover
{
    public class GameCycle : Game
    {
        private GraphicsDeviceManager _graphics;
        private SpriteBatch _spriteBatch;
        public MainMenuDrawer menuDrawer;
        public MainMenu mainMenu;

        Texture2D texture;
        Texture2D Back;
        SpriteFont textBlock;


        public GameCycle()
        {
            _graphics = new GraphicsDeviceManager(this);
            _graphics.PreferredBackBufferWidth = 1280;
            _graphics.PreferredBackBufferHeight = 720;
            _graphics.ApplyChanges();

            Content.RootDirectory = "Content";
            IsMouseVisible = true;
        }

        protected override void Initialize()
        {
            // TODO: Add your initialization logic here


            mainMenu = new MainMenu();
            base.Initialize();
        }

        protected override void LoadContent()
        {
            _spriteBatch = new SpriteBatch(GraphicsDevice);
            menuDrawer = new MainMenuDrawer(_spriteBatch, Content);

            texture = Content.Load<Texture2D>("None");

            //button.ClickEvent += DoSom;

            // TODO: use this.Content to load your game content here
        }

        protected override void Update(GameTime gameTime)
        {
            if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed || Keyboard.GetState().IsKeyDown(Keys.Escape))
                Exit();
            base.Update(gameTime);
        }

        protected override void Draw(GameTime gameTime)
        {

            /*GraphicsDevice.Clear(Color.CornflowerBlue);
            var battle = new Battle(BattleMap.Positions.MiddleLineRover,
                new Enemy() { Texture = texture, Position = DrawPositions.NearLineEnemy },
                new Enemy() { Texture = texture, Position = DrawPositions.MiddleLineEnemy },
                new Enemy() { Texture = texture, Position = DrawPositions.BacklineEnemy });
            var drawBattle = new DrawBattle(_spriteBatch, battle, texture);
            drawBattle.LoadContentManager(Content);
            drawBattle.Draw();
            */


            menuDrawer.Draw(mainMenu);



            base.Draw(gameTime);
        }


    }
}