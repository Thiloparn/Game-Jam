using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    public int damage;
    public Vector2 direction;
    public int speed;

    public new Rigidbody2D rigidbody;

    public void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Heart")
        {
            Heart heart = collision.GetComponent<Heart>();
            heart.lifes -= damage;

            if (heart.lifes <= 0)
            {
                Destroy(heart.gameObject);
            }

            Destroy(this.gameObject);
        } 
        else if (collision.tag == "Hero") 
        {
            Hero hero = collision.GetComponent<Hero>();

            if (hero.ready)
            {
                hero.ready = false;
            }
            else
            {
                hero.lifes -= damage;

                if (hero.lifes <= 0)
                {
                    Destroy(hero.gameObject);
                }

            }

            Destroy(this.gameObject);
        }
    }

    void Update()
    {
        rigidbody.velocity = direction * speed;
    }
}
