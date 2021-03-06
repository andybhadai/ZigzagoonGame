﻿using Otter;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZigzagoonOtterEngine.Character
{
    public interface ICharacter
    {
        string Species { get; }
        int Health { get; set; }
        int Attack { get; }
        int Defence { get; }
        int Speed { get; }
        void Move();
    }
}
