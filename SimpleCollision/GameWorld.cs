using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleCollision
{
    /// <summary>
    /// This is the main type for your game.
    /// </summary>
    public class GameWorld : Game
    {
        GraphicsDeviceManager graphics;
        SpriteBatch spriteBatch;

        public Vector2 position;
        public KeyboardState keyState;

        Color playerColor = Color.White;
        Texture2D playerSprite, enemySprite;
        float moveSpeed = 50f;
        Rectangle player, enemy;


        public GameWorld()
        {
            graphics = new GraphicsDeviceManager(this);
            Content.RootDirectory = "Content";
        }

        /// <summary>
        /// Allows the game to perform any initialization it needs to before starting to run.
        /// This is where it can query for any required services and load any non-graphic
        /// related content.  Calling base.Initialize will enumerate through any components
        /// and initialize them as well.
        /// </summary>
        protected override void Initialize()
        {
            // TODO: Add your initialization logic here

            base.Initialize();
        }

        /// <summary>
        /// LoadContent will be called once per game and is the place to load
        /// all of your content.
        /// </summary>
        protected override void LoadContent()
        {
            // Create a new SpriteBatch, which can be used to draw textures.
            spriteBatch = new SpriteBatch(GraphicsDevice);
            playerSprite = Content.Load<Texture2D>("1player");

            enemySprite = Content.Load<Texture2D>("1trashcan");



            // TODO: use this.Content to load your game content here
        }

        /// <summary>
        /// UnloadContent will be called once per game and is the place to unload
        /// game-specific content.
        /// </summary>
        protected override void UnloadContent()
        {
            // TODO: Unload any non ContentManager content here
        }

        /// <summary>
        /// Allows the game to run logic such as updating the world,
        /// checking for collisions, gathering input, and playing audio.
        /// </summary>
        /// <param name="gameTime">Provides a snapshot of timing values.</param>
        protected override void Update(GameTime gameTime)
        {


            if (GamePad.GetState(PlayerIndex.One).Buttons.Back == ButtonState.Pressed || Keyboard.GetState().IsKeyDown(Keys.Escape))
                Exit();

            keyState = Keyboard.GetState();

            if (keyState.IsKeyDown(Keys.D))
            {
                position.X += moveSpeed * (float)gameTime.ElapsedGameTime.TotalSeconds;
            }
            else if (keyState.IsKeyDown(Keys.A))
                position.X -= moveSpeed * (float)gameTime.ElapsedGameTime.TotalSeconds;
            else if (keyState.IsKeyDown(Keys.W))
                position.Y -= moveSpeed * (float)gameTime.ElapsedGameTime.TotalSeconds;
            else if (keyState.IsKeyDown(Keys.S))
                position.Y += moveSpeed * (float)gameTime.ElapsedGameTime.TotalSeconds;


            if (position.X + playerSprite.Width < 100 || position.X > 100 + enemySprite.Width || position.Y + playerSprite.Height < 100 || position.Y > 100 + enemySprite.Height)
            {
                // No collision
                playerColor = Color.White;
            }
            else
            {
                // Collision
                playerColor = Color.Red;
            }

            base.Update(gameTime);
        }

        /// <summary>
        /// This is called when the game should draw itself.
        /// </summary>
        /// <param name="gameTime">Provides a snapshot of timing values.</param>
        protected override void Draw(GameTime gameTime)
        {
            GraphicsDevice.Clear(Color.CornflowerBlue);

            spriteBatch.Begin();

            spriteBatch.Draw(playerSprite, position, playerColor);
            spriteBatch.Draw(enemySprite, new Vector2(100, 100), Color.White);

            spriteBatch.End();

            base.Draw(gameTime);
        }
    }
}
