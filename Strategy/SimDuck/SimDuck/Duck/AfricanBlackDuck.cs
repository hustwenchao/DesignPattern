﻿using SimDuck.QuackBehavior;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimDuck
{
    public class AfricanBlackDuck : Duck
    {
        public AfricanBlackDuck()
        {
            quackBehavior = new Quack();
            flyBehavior = new FlyWithWing();
        }
    }
}
