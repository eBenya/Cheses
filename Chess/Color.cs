using System;
using System.Collections.Generic;
using System.Text;

namespace Chess
{
    enum Color
    {
        none,
        white,
        black
    }

    static class ColorMeth
    {
        /// <summary>
        /// Method which conduct next player`s turn 
        /// </summary>
        /// <param name="color">Player`s piece color</param>
        /// <returns></returns>
        public static Color FlipColor(this Color color)
        {
            if (color == Color.black) return Color.white;
            if (color == Color.white) return Color.black;
            return Color.none;
        }
    }
}
