﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Microsoft.Xna.Framework;
using TomAndJerry.Interfaces;

namespace TomAndJerry.Objects.Items
{
    public abstract class Item : GameObject, IMovable
    {
        public Vector2 Velocity { get; set; }
        public float MoveSpeed { get; set; }
    }
}
