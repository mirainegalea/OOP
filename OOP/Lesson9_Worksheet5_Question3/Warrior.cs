﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson9_Worksheet5_Question3
{
      
    class Warrior: Character
    {
        public Warrior():base(300,0,120)
        { }

        public override void Attack(Character character)
        {
            character.Health -= Damage;
        }

      
    }
}
