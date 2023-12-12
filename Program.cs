﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB10_SOLID
{
    internal class Program
    {
        class Triangle
        {
            public virtual int Width { get; set; }
            public virtual int Height { get; set; }

            public int GetArea()
            {
                return Width * Height;
            }
        }

        class Square : Triangle
        {
            public override int Width
            {
                get
                {
                    return base.Width;
                }

                set
                {
                    base.Width = value;
                    base.Height = value;
                }
            }

            public override int Height
            {
                get
                {
                    return base.Height;
                }

                set
                {
                    base.Height = value;
                    base.Width = value;
                }
            }
        }


    }
}

