using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coord
{
    float X;
    float Y;
    float Z;

    public Coord(float x, float y)
    {
        X = x;
        Y = y;
        Z = -1;
    }

    public override string ToString()
    {
        return "(" + X + " , " + Y + ", " + Z + ")";
    }
}
