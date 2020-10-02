using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Threading;
using UnityEngine;

public class pathing : MonoBehaviour
{
    [SerializeField]
    private FieldOfView fieldOfView;

    public float speed;
    private float wait;
    public float startwait;

    public Transform[] spots;

    private int random;

    void Start()
    {
        wait = startwait;
        random = Random.Range(0, spots.Length);

    }

    void Update()
    {
        transform.position = Vector2.MoveTowards(transform.position, spots[random].position, speed * Time.deltaTime);

        fieldOfView.SetAimDirection(spots[random].position);
        fieldOfView.SetOrigin(transform.position);
    

        if(Vector2.Distance(transform.position, spots[random].position) < 0.2f)
        {
            if (wait <= 0)
            {
                random = Random.Range(0, spots.Length);
                wait = startwait;
            }
            else
            {
                wait -= Time.deltaTime;
            }
        }
    }
}
