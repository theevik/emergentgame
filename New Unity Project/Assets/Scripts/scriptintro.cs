using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class scriptintro : MonoBehaviour
{
    [SerializeField]
    private SpriteRenderer sprite;
    [SerializeField]
    private Rigidbody2D rigidbody;
    [SerializeField]
    private float speed = 2;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        var horizontal = Input.GetAxis("Horizontal");
        var vertical = Input.GetAxis("Vertical");

        rigidbody.velocity = new Vector2(horizontal, vertical) * speed;
        var totalSpeed = rigidbody.velocity.magnitude;

        var dir = Input.mousePosition - Camera.main.WorldToScreenPoint(transform.position);
        var angle = Mathf.Atan2(dir.y, dir.x) * Mathf.Rad2Deg;
        transform.rotation = Quaternion.AngleAxis(angle, Vector3.forward);
    }
}
