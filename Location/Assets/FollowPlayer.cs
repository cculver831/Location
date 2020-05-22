using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    public Transform player; //takes in player Gameobject for camera to follow

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //update pos of camera
        transform.position = new Vector3(player.position.x, player.position.y, transform.position.z);
    }
}
