using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy1L : EnemyZombie
{
    public override void Update()
    {
        if (Time.time < FirstMove + 2.5f)
        {
            transform.position += Vector3.right * speed * Time.deltaTime;
        }
        else if (Time.time > FirstMove + 2.5f)
        {
            if (!ZombieStack)
            {
                transform.position = Vector2.MoveTowards(transform.position, Player.transform.position, speed * Time.deltaTime);
            }
        }

        EnemyDead();
    }
}