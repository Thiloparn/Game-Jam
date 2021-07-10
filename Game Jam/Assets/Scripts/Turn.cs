using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Turn : MonoBehaviour
{
    public Vector2 direction;

    private void OnTriggerStay2D(Collider2D collision)
    {
        if(collision.tag == "Enemy" && collision.transform.position == transform.position)
        {
            Enemy enemy = collision.GetComponent<Enemy>();
            enemy.direction = direction;
        }
    }
}
