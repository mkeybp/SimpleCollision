//using Microsoft.Xna.Framework;
//using Microsoft.Xna.Framework.Content;
//using Microsoft.Xna.Framework.Graphics;
//using Microsoft.Xna.Framework.Input;
//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;


//namespace SimpleCollision
//{
//    class Player : GameObject
//    {

//        public void HandleInput(GameTime gameTime)
//        {
//            currentKey = Keyboard.GetState();
//            previousKey = currentKey;

//            velocity = Vector2.Zero;

//            if (currentKey.IsKeyDown(Keys.D))
//            {
//                velocity += new Vector2(1, 0);
//            }
//            if (currentKey.IsKeyDown(Keys.A))
//            {
//                velocity += new Vector2(-1, 0);
//            }
//            if (currentKey.IsKeyDown(Keys.W))
//            {
//                velocity += new Vector2(0, -1);
//            }
//            if ((currentKey.IsKeyDown(Keys.D)) || (currentKey.IsKeyDown(Keys.A)) || currentKey.IsKeyDown(Keys.S))
//            {
//                //Animation(gameTime);
//            }
//            if (velocity != Vector2.Zero)
//            {
//                velocity.Normalize();
//            }
//        }

//        public override void Update(GameTime gameTime)
//        {
//            HandleInput(gameTime);
//            Move(gameTime);
//            //Animation(gameTime);
//        }

//        public void Move(GameTime gameTime)
//        {
//            float deltaTime = (float)gameTime.ElapsedGameTime.TotalSeconds;

//            position += ((velocity * speed) * deltaTime);
//        }
//    }
//}
