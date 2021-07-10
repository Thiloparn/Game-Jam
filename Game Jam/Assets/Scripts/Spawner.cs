using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public int speed;
    public float timer;
    public Vector2 direction;

    public List<Enemy> enemies;

    void Update()
    {
        timer += Time.deltaTime;

        if(timer >= speed)
        {
            timer = 0;
            Enemy enemy = enemies[0];
            enemy.direction = direction;
            Instantiate(enemy, this.transform.position, Quaternion.identity);
        }
    }
}
