﻿//using Microsoft.Xna.Framework;
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
//    public abstract class GameObject
//    {
//        //Flere sprites i et array.
//        protected Texture2D[] sprites;
//        //En sprite.
//        protected Texture2D sprite;
//        //Frames per seconds, bruges til animation af sprites.
//        protected int fps;
//        //Bruges til Player og Enemey movement.
//        protected float speed;
//        //Bruges også til Player og Enemy movement.
//        protected Vector2 velocity;
//        //Bruges til at holde styr på Player og Enemy position.
//        protected Vector2 position;
//        //Bruges til at finde midtpunket af Player og Enemy sprite.
//        protected Vector2 origin;
//        //Holder styr på hvilken tast som bliver brugt i øjeblikket.
//        protected KeyboardState currentKey;
//        //Holder styr på hvilken key som blev brugt sidst.
//        protected KeyboardState previousKey;
//        //Holder styr på hvor langt man er i et Array.
//        private int currentIndex;
//        //
//        private float timeElapsed;


//        public abstract void LoadContent(ContentManager content);

//        public abstract void Update(GameTime gameTime);
//    }
//}
