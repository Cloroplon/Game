﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Content;
using Microsoft.Xna.Framework.Graphics;

namespace TomAndJerry
{
    interface IState
    {
        void LoadContent(ContentManager contentManager);
        
        void UnloadContent();
        
        void Draw(SpriteBatch spriteBatch);
        
        void Update(GameTime gameTime);
    }
}
