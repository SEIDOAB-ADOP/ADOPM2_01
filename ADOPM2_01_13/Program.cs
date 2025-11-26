using System;

namespace ADOPM2_01_13
{
    class Program
    {
        public class RectangleClass
        {
            public long Width { get; set; }
            public long Height { get; set; }
            public long Area => Width * Height;

            //Operator overloading
            public static bool operator ==(RectangleClass a, RectangleClass b) => (a.Width, a.Height) == (b.Width, b.Height);
            public static bool operator !=(RectangleClass a, RectangleClass b) => (a.Width, a.Height) != (b.Width, b.Height);
            public static RectangleClass operator +(RectangleClass a, RectangleClass b) => 
                new RectangleClass {Height = a.Height + b.Height, Width = a.Width + b.Width};

        }
        static void Main(string[] args)
        {
            RectangleClass r1 = new RectangleClass { Width = 100, Height = 100 };
            RectangleClass r2 = new RectangleClass { Width = 200, Height = 200 };

            Console.WriteLine(r1 == r2); // false
            Console.WriteLine(r1 != r2); // true

            var r3 = r1 + r2;
            r1 += r2;
            Console.WriteLine(r3.Height);
            Console.WriteLine(r1.Height);
        }
    }
}
//Excercises:
//1.    Create a RectangleStruct with same functionality as RectangleClass

