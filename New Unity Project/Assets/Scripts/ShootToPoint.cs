using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootToPoint : MonoBehaviour
{
    [SerializeField]
    private GameObject Bullet;

    [SerializeField]
    private float BulletSpeed = 10;
    // Update is called once per frame
    void Update()
    {

        if (Input.GetMouseButtonDown(0))
        {
            Vector2 target = Camera.main.ScreenToWorldPoint(new Vector2(Input.mousePosition.x, Input.mousePosition.y));
            Vector2 player = new Vector2(transform.position.x, transform.position.y);
            Vector2 direction = target - player;
            direction.Normalize();
            Quaternion rotation = Quaternion.Euler(0, 0, Mathf.Atan2(direction.y, direction.x) * Mathf.Rad2Deg);

            GameObject bullet = (GameObject)Instantiate(Bullet, player, rotation);
            bullet.GetComponent<Rigidbody2D>().velocity = direction * BulletSpeed;
        }
    }
}
