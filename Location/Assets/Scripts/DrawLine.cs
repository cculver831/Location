using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DrawLine : MonoBehaviour
{

    //Coord point = new Coord(10, 1); //test point

    //draw axis
    Coord startpoint = new Coord(0, 100);
    Coord endPoint = new Coord(0, -100);
    Coord startpointx = new Coord(100, 0);
    Coord endPointx = new Coord(-100, 0);
    // Start is called before the first frame update
    void Start()
    {
        Coord.DrawLine(startpoint, endPoint, 2, Color.yellow);
        Coord.DrawLine(startpointx, endPointx, 2, Color.yellow);
    }


}
