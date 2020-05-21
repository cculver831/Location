using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DrawLine : MonoBehaviour
{

    Coord point = new Coord(10, 1);

    //draw axis
    Coord startpoint = new Coord(0, 100);
    Coord endPoint = new Coord(0, -100);
    Coord startpointx = new Coord(100, 0);
    Coord endPointx = new Coord(-100, 0);
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log(point.ToString());
        Coord.DrawPoint(point, 2, Color.green);
        Coord.DrawLine(startpoint, endPoint, 2, Color.yellow);
        Coord.DrawLine(startpointx, endPointx, 2, Color.yellow);
    }

    // Update is called once per frame
    void Update()
    {
         
    }
}
