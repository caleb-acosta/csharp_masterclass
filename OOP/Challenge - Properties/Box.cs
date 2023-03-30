using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Properties
{
    internal class Box
    {
        private int height;
        private int width;
        private int length;

        public int Height {
            get { return height; } set {  height = value; }
        }

        public int Width { 
            get { return width; } set { width = value;  }
        }

        public int Length { 
            get { return length; } set {  length = value; }
        }
        public int FrontSurface {
            get { return height * length; }
        }

        public int Volume { get { return height * width * length; } }

        public Box(int height, int width, int length)
        {
            this.height = height;
            this.width = width;
            this.length = length;
        }
    }
}
