using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam70483_4
{
    public interface IThreeDimensional
    {
        int Length { get; set; }
        int Height { get; set; }
        int Width { get; set; }
    }

    class Box : IThreeDimensional, IEquatable<Box>
    {
        public int Length { get; set; }
        public int Height { get; set; }
        public int Width { get; set; }
        public string Color { get; set; }

        public Box(int l, int h, int w, string c)
        {
            Length = l;
            Height = h;
            Width = w;
            Color = c;
        }


        public bool Equals(Box other)
        {
            if (Length == other.Length && Height == other.Height && Width == other.Width)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        //TODO: why do we need to override these two??
        public override bool Equals(object obj)
        {
            return base.Equals(obj);
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
    }
}
