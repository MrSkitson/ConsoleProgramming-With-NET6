﻿abstract class Shape
{
    public double Height { get; set; }
    public double Length { get; set; }

    public double getArea()
    {
        return Length * Height;
    }

}