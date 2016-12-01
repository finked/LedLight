using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;

namespace LedLight
{
    public class ScreenDevice
    {
        private Rectangle[] _rect;
        private int _width;
        private int _height;
        private int _xpos;
        private int _ypos;

        public ScreenDevice()
        {
        }

        ~ScreenDevice()
        {
        }

        public Rectangle[] Rect
        {
            get
            {
                return _rect;
            }
            set
            {
                _rect = value;
            }
        }

        public int Width
        {
            get
            {
                return _width;
            }
            set
            {
                _width = value;
            }
        }

        public int Height
        {
            get
            {
                return _height;
            }
            set
            {
                _height = value;
            }
        }

        public int XPos
        {
            get
            {
                return _xpos;
            }
            set
            {
                _xpos = value;
            }
        }

        public int YPos
        {
            get
            {
                return _ypos;
            }
            set
            {
                _ypos = value;
            }
        }
    }

    public struct LED
    {
        private int _rectID;
        private double[] _Intensity;
        private byte[] _color;
        public int _id;

        public int RectID
        {

            get
            {
                return _rectID;
            }
            set
            {
                _rectID = value;
            }
        }

        public double[] Intensity
        {
            get
            {
                return _Intensity;
            }
            set
            {
                _Intensity = value;
            }
        }

        public byte[] Color
        {
            get
            {
                return _color;
            }
            set
            {
                _color = value;
            }
        }
        
        public int Modifier
        {
            get
            {
                throw new System.NotImplementedException();
            }
            set
            {
            }
        }
    }
}
