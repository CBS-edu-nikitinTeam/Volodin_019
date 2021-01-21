using System;

namespace Exercise2
{
    public enum Color : int
    {
        Red,
        Blue,
        Green,
    }

    class ColorProvider
    {
        public static ConsoleColor Provide(Color color)
        {
            return (color) switch
            {
                Color.Red => ConsoleColor.Red,
                Color.Blue => ConsoleColor.Blue,
                Color.Green => ConsoleColor.Green,
                _ => ConsoleColor.Black,
            };
        }
    }
}
