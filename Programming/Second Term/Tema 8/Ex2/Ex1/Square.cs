﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ex2
{
    public class Square: Shape
    {
        private int height;

        public int Height 
        { 
            get {  return height; } 
            set {  height = value; } 
        }

        public Square(int x, int y, string color, int height) : base(x, y, color)
        {
            Height = height;
        }

        public override double CalculateArea()
        {
            return Height * Height;
        }
        public override double CalculatePerimeter()
        {
            return Height * 4;
        }
        public override string SayMyName()
        {
            return "Soy un cuadrado";
        }

        public override string ToString()
        {
            return $"{SayMyName()} " +
                $"\nPosition X: {xPosition} " +
                $"\nPosition Y: {yPosition} " +
                $"\nColor: {Color}" +
                $"\nHeight: {Height}" +
                $"\nPerimeter: {CalculatePerimeter()}" +
                $"\nArea: {CalculateArea()}\n\n";
        }
    }
}
