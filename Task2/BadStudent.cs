﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Task2
{
    class BadStudent : Student
    {
        public BadStudent(string name) : base(name)
        {
            this.state = "bad";
        }

        public override void Study()
        {
            Relax();
            Relax();
            Relax();
            Read();
        }
    }
}
