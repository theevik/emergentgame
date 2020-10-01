using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class playerdeath : MonoBehaviour
{
    
    private void OnCollisionEnter2D(Collision2D collision)
    {
        var respawn = GameObject.FindGameObjectWithTag("Respawn").transform.position;
        

        if(collision.gameObject.GetComponent<pathing>())
        {
            transform.position = respawn;
        }
    }

}
