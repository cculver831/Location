using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DrawLine : MonoBehaviour
{

    Coord point = new Coord(10, 1);
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log(point.ToString());
        Coord.DrawPoint(point, 2, Color.green);
    }

    // Update is called once per frame
    void Update()
    {
         
    }
}
