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
    static public void DrawPoint(Coord position, float width, Color color)
    {
        GameObject line = new GameObject("Point_" + position.ToString());
        LineRenderer lineRenderer = line.AddComponent<LineRenderer>();
        lineRenderer.material = new Material(Shader.Find("Unlit/Color"));
        lineRenderer.material.color = color;
        lineRenderer.positionCount = 2; //sets # of vertices (lines only need two)
        lineRenderer.SetPosition(0, new Vector3(position.X - width / 3.0f, position.Y - width / 3.0f,position.Z));
        lineRenderer.SetPosition(1, new Vector3(position.X + width / 3.0f, position.Y + width / 3.0f, position.Z));
        lineRenderer.startWidth = width;
        lineRenderer.endWidth = width;

    }

    static public void DrawLine(Coord startPos,Coord endPos, float width, Color color)
    {
        GameObject line = new GameObject("Point_" + startPos.ToString());
        LineRenderer lineRenderer = line.AddComponent<LineRenderer>();
        lineRenderer.material = new Material(Shader.Find("Unlit/Color"));
        lineRenderer.material.color = color;
        lineRenderer.positionCount = 2; //sets # of vertices (lines only need two)
        lineRenderer.SetPosition(0, new Vector3(startPos.X, startPos.Y, startPos.Z));
        lineRenderer.SetPosition(1, new Vector3(endPos.X,endPos.Y, endPos.Z));
        lineRenderer.startWidth = width;
        lineRenderer.endWidth = width;
    }
}
