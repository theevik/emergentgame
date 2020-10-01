using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Security.Cryptography;
using System.Threading;
using UnityEngine;

public class scriptintro : MonoBehaviour
{

    public float Speed = 5f;
    public Rigidbody2D rb;
    Vector2 movement;

    public GameObject respawn;

    // Start is called before the first frame update
    void Start()
    {
        transform.position = respawn.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        movement.x = Input.GetAxisRaw("Horizontal");
        movement.y = Input.GetAxisRaw("Vertical");
    }

    void FixedUpdate()
    {
        rb.MovePosition(rb.position + movement * Speed * Time.fixedDeltaTime);
    }

    
}
