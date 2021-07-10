using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Split : MonoBehaviour
{
    public Vector2 direction1;
    public Vector2 direction2;

    public int lastDirection;

    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.tag == "Enemy")
        {
            Enemy enemy = collision.GetComponent<Enemy>();
            if(lastDirection == 1)
            {
                /*if (direction2.x == 0)
                {
                    if ((enemy.rigidbody.velocity.x > 0 && enemy.transform.position.x > transform.position.x) ||
                        (enemy.rigidbody.velocity.x < 0 && enemy.transform.position.x < transform.position.x))
                    {
                        enemy.transform.position = new Vector2(transform.position.x, enemy.transform.position.y);
                    }
                } 
                else
                {
                    if ((enemy.rigidbody.velocity.y > 0 && enemy.transform.position.y > transform.position.y) ||
                        (enemy.rigidbody.velocity.y < 0 && enemy.transform.position.y < transform.position.y))
                    {
                        enemy.transform.position = new Vector2(enemy.transform.position.x, transform.position.y);
                    }
                }*/

                enemy.direction = direction2;
                lastDirection = 2;
            }
            else
            {
                /*if (direction1.x == 0)
                {
                    if ((enemy.rigidbody.velocity.x > 0 && enemy.transform.position.x > transform.position.x) ||
                        (enemy.rigidbody.velocity.x < 0 && enemy.transform.position.x < transform.position.x))
                    {
                        enemy.transform.position = new Vector2(transform.position.x, enemy.transform.position.y);
                    }
                }
                else
                {
                    if ((enemy.rigidbody.velocity.y > 0 && enemy.transform.position.y > transform.position.y) ||
                        (enemy.rigidbody.velocity.y < 0 && enemy.transform.position.y < transform.position.y))
                    {
                        enemy.transform.position = new Vector2(enemy.transform.position.x, transform.position.y);
                    }
                }*/

                enemy.direction = direction1;
                lastDirection = 1;
            }
        }
    }
}
