﻿using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace Template
{
    /// <summary>
    /// This is the main type for your game.
    /// </summary>
    public class Game1 : Game
    {
        GraphicsDeviceManager graphics;
        SpriteBatch spriteBatch;
        Texture2D rödLåda;
        Rectangle rödLådaKollisionskollare;
        Rectangle blåLådaKollisionskollare;
        Vector2 rödLådaPos;

        //KOmentar
        public Game1()
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
            Vector2 rödLådaPos = new Vector2(500, 0);
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

            rödLåda = Content.Load<Texture2D>("RödLåda");

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

            // TODO: Add your update logic here
            KeyboardState kstate = Keyboard.GetState();

            if(kstate.IsKeyDown(Keys.NumPad1))
            {

            }
            else if (kstate.IsKeyDown(Keys.NumPad2))
            {

            }
            else if (kstate.IsKeyDown(Keys.NumPad2))
            {

            }
            base.Update(gameTime);

            if (kstate.IsKeyDown(Keys.W))
            {
                rödLådaPos.Y += wKnappen;
            }
            else if (kstate.IsKeyDown(Keys.A))
            {
                rödLådaPos.X += aKnappen;
            }
            else if (kstate.IsKeyDown(Keys.D))
            {
                rödLådaPos.X += dKnappen;
            }
            else if (kstate.IsKeyDown(Keys.S))
            {
                rödLådaPos.Y += sKnappen;
            }
            base.Update(gameTime);
        }

        /// <summary>
        /// This is called when the game should draw itself.
        /// </summary>
        /// <param name="gameTime">Provides a snapshot of timing values.</param>
        protected override void Draw(GameTime gameTime)
        {
            //GraphicsDevice.Clear(Color.CornflowerBlue);
            GraphicsDevice.Clear(Color.Red);

            // TODO: Add your drawing code here.
            spriteBatch.Begin();
            spriteBatch.Draw(rödLåda, rödLådaPos, Color.White);
            spriteBatch.End();

            base.Draw(gameTime);
        }
    }
}
