using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollowScript : MonoBehaviour
{

    public GameObject player;
    
    // Update is called once per frame
    void Update()
    {
        Vector3 vector = player.transform.position = new Vector3(player.transform.position.x, player.transform.position.y,0);
        transform.position = vector + new Vector3 (0,0,-10);
    }
}
