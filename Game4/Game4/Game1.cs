using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using Microsoft.Xna.Framework.Input;

namespace Game4
{
    /// <summary>
    /// This is the main type for your game.
    /// </summary>
    public class Game1 : Game
    {
        Texture2D imagen, imagen2; //aqui se almacena el sprite
        private Vector2 Vector2;
        private Vector2 vector3;
        Vector2 Posicion ; //alamacena la pocision inicial en la pantalla de carga
        Vector2 PosicionBlond; //flechas
        GraphicsDeviceManager graphics;
        SpriteBatch spriteBatch;
        int posx;
        int posy;
        bool direccion_horizontal;
        bool direccion_vertical;
        



        private object spriteffects;

      

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
            // se crea un spritebatch y agregarle una textura

            spriteBatch = new spriteBatch(GraphicsDevice);
            imagen = Content.Load<Texture2D>("weed"); //elegimos la textura 
            imagen2 = Content.Load<Texture2D>("Weed2");

            posx = 2;
            posy = 1;
            this.Posicion = new Vector2(100,100);
            this.PosicionBlond = new Vector2(350,350);
            direccion_horizontal = true;
            direccion_vertical = true;
          
            
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

            //revotar en x
            if (Posicion.X >= 665)
            {
                direccion_horizontal = false;
            }

            else  if(Posicion.X <= 0)
            {
                     direccion_horizontal = true;
            }

            if (direccion_horizontal ==true)
            {

                Posicion.X += 5;
            }

            else if(direccion_horizontal == false)
            {
                Posicion.X -= 5;
            }

            //revotar en y
            if (Posicion.Y >= 365)
            {
                direccion_vertical = false;
            }

            else if (Posicion.Y <= 0)
            {
                direccion_vertical = true;
            }

            if (direccion_vertical == true)
            {
                Posicion.Y += 5;
            }

            else if (direccion_vertical == false)
            {
                Posicion.Y -= 5;

            }
            // flechas


            if (PosicionBlond.X >= 700)
            {

            }
            else if (Keyboard.GetState().IsKeyDown(Keys.Right))
            {
                PosicionBlond.X += 5;
            }

            if (PosicionBlond.X <= 0)
            {
                PosicionBlond.X += 0;
            }
            else if (Keyboard.GetState().IsKeyDown(Keys.Left))
            {
                PosicionBlond.X -= 5;
            }


        }

        /// <summary>
        /// This is called when the game should draw itself.
        /// </summary>
        /// <param name="gameTime">Provides a snapshot of timing values.</param>
        protected override void Draw(GameTime gameTime)
        {
            
            spriteBatch.Begin();


            // GraphicsDevice.Clear(Color.Black);
            //spriteBatch.Draw(imagen, Posicion, new Rectangle(posx, posy, imagen.Width,imagen.Height),
            //Color.White, 0, Vector2.Zero, 1 / 5f, SpriteEffects.None, 0); 
            //spriteBatch.End(
            spriteBatch.Draw(imagen, Posicion, new Rectangle(posx, posy, imagen.Width, imagen.Height), Color.White, 0, Vector2.Zero, 1 / 5f, SpriteEffects.None, 0);
            spriteBatch.Draw(imagen2, PosicionBlond, new Rectangle(posx, posy, imagen.Width, imagen.Height), Color.White, 0, Vector2.Zero, 2/3f, SpriteEffects.None, 0);



            GraphicsDevice.Clear(Color.Black);
            spriteBatch.End();
            
        
            base.Draw(gameTime);

                  // TODO: Add your drawing code here

        
        }
    }
}
