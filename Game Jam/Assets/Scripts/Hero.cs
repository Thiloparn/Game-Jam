using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hero : MonoBehaviour
{
    public int lifes;
    public int damage;
    public int attackSpeed;
    public float attackTimer;

    public bool ready;

    void Update()
    {
        attackTimer += Time.deltaTime;

        if (attackTimer >= attackSpeed)
        {
            attackTimer = 0;
            ready = true;
        }
    }
}
