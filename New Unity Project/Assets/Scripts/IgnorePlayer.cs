using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IgnorePlayer : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D other)
    {
        var player = other.gameObject.GetComponent<scriptintro>();
        if (player) {
            Physics2D.IgnoreCollision(player.GetComponent<Collider2D>(), GetComponent<Collider2D>());
        }
    }
}
