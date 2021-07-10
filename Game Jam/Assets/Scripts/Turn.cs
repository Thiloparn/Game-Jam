using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Turn : MonoBehaviour
{
    public Vector2 direction;

    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.tag == "Enemy")
        {
            Enemy enemy = collision.GetComponent<Enemy>();
            if(direction.x == 0)
            {
                enemy.transform.position = new Vector2(transform.position.x - 1, enemy.transform.position.y);
            } 
            else
            {
                enemy.transform.position = new Vector2(enemy.transform.position.x, transform.position.y);
            }
            enemy.direction = direction;
        }
    }
}
